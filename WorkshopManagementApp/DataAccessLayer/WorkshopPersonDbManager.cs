using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Models;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class WorkshopPersonDbManager: DbAccess
    {
        public WorkshopPersonDbManager(string dbConnectionStr) : base(dbConnectionStr)
        {
        }

        public override void Create(object obj)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {
                    WorkshopPerson currWorkshopPerson = obj as WorkshopPerson;
                    
                    string sql = "INSERT into workshop_person(WorkshopID, PersonPcn, SeatNr, LoginCode) " +
                                 "VALUES(@workshopId, @personPcn, @seatNr, @loginCode)";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);

                    cmd.Parameters.AddWithValue("@workshopId", currWorkshopPerson.Workshop.Id);
                    cmd.Parameters.AddWithValue("@personPcn", currWorkshopPerson.Person.Pcn);

                    if (currWorkshopPerson is OnsiteWorkshopPerson)
                    {
                        cmd.Parameters.AddWithValue("@seatNr", (currWorkshopPerson as OnsiteWorkshopPerson).SeatNr);
                        cmd.Parameters.AddWithValue("@loginCode", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@seatNr", null);
                        cmd.Parameters.AddWithValue("@loginCode", (currWorkshopPerson as OnlineWorkshopPerson).LoginCode);
                    }

                    DbConn.Open();

                    base.ExecuteNonQuery(cmd);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override object Read(object identifier)
        {
            throw new NotImplementedException();
        }

        public override object ReadAll()
        {
            List<WorkshopPerson> workshopPeople = new List<WorkshopPerson>();
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {

                    string sql = "SELECT * from workshop_person as wp " +
                                 "inner join workshop as w " +
                                 "on wp.WorkshopID = w.ID " +
                                 "left join person as t " +
                                 "on w.TeacherPCN = t.Pcn " +
                                 "inner join person as p " +
                                 "on p.Pcn = wp.PersonPcn";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);

                    DbConn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        int workshopId = Convert.ToInt32(dr[1]);
                        int personId = Convert.ToInt32(dr[2]);
                        int seatNr;
                        if (dr[3].ToString() != "")
                        {
                            seatNr = Convert.ToInt32(dr[3]);
                        }
                        else
                        {
                            seatNr = -1;
                        }

                        string loginCode = dr[4].ToString();

                        //int id = Convert.ToInt32(dr[5]);
                        string title = dr[6].ToString();
                        string shortDescription = dr[7].ToString();
                        int capacity = Convert.ToInt32(dr[8]);
                        int nrOfParticipants = Convert.ToInt32(dr[9]);
                        bool isAvailable = Convert.ToBoolean(dr[10]);
                        bool isStarted = Convert.ToBoolean(dr[11]);
                        string teacherPCN = dr[12].ToString();
                        string address = dr[13].ToString();
                        string roomNr = dr[14].ToString();
                        string url = dr[15].ToString();

                        Person teacher = null;
                        if (teacherPCN != "")
                        {
                            string teacherPcn = dr[16].ToString();
                            string teacherFname = dr[17].ToString();
                            string teacherLname = dr[18].ToString();
                            string teacherEmail = dr[19].ToString();
                            string teacherRole = dr[20].ToString();
                            teacher = new Teacher(teacherFname, teacherLname, teacherPCN, teacherEmail, teacherRole);
                        }

                        Workshop currWorkshop;
                        if (url != "")
                        {
                            currWorkshop = new OnlineWorkshop(workshopId, title, shortDescription, capacity,
                                nrOfParticipants, isAvailable, isStarted, teacher, url);
                        }
                        else
                        {
                            currWorkshop = new OnsiteWorkshop(workshopId, title, shortDescription, capacity,
                                nrOfParticipants, isAvailable, isStarted, teacher, address, roomNr);
                        }

                        string pcn = dr[21].ToString();
                        string fname = dr[22].ToString();
                        string lname = dr[23].ToString();
                        string email = dr[24].ToString();
                        string role = dr[25].ToString();

                        Person currPerson;
                        if (role == "Student")
                        {
                            currPerson = new Student(fname, lname, pcn, email, role);
                        }
                        else
                        {
                            currPerson = new Teacher(fname, lname, pcn, email, role);
                        }



                        WorkshopPerson currWorkshopPerson;
                        if (loginCode != "")
                        {
                            currWorkshopPerson = new OnlineWorkshopPerson(id, currWorkshop, currPerson, loginCode);
                        }
                        else
                        {
                            currWorkshopPerson = new OnsiteWorkshopPerson(id, currWorkshop, currPerson, seatNr);
                        }
                        workshopPeople.Add(currWorkshopPerson);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return workshopPeople;
        }

        public override void Update(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(object identifier)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {

                    string sql = "DELETE from workshop_person WHERE ID=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(identifier));

                    DbConn.Open();
                    base.ExecuteNonQuery(cmd);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
