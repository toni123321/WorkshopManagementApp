using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Models;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class WorkshopDbManager: DbStorage
    {
        public WorkshopDbManager(string dbConnectionStr) : base(dbConnectionStr)
        {
        }

        public override void Create(object obj)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {
                    Workshop currWorkshop = (Workshop)obj;
                    string sql = "INSERT into workshop(Title, ShortDescription, Capacity, NrOfParticipants, IsAvailable, IsStarted, TeacherPCN, " +
                                 "Address, RoomNr, Url) " +
                                 "VALUES(@title, @shortDescription, @capacity, @nrOfParticipants, @isAvailable, @isStarted, @teacherPCN, " +
                                 "@address, @roomNr, @url)";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);

                    cmd.Parameters.AddWithValue("@title", currWorkshop.Title);
                    cmd.Parameters.AddWithValue("@shortDescription", currWorkshop.Title);
                    cmd.Parameters.AddWithValue("@capacity", currWorkshop.Capacity);
                    cmd.Parameters.AddWithValue("@nrOfParticipants", currWorkshop.NrOfParticipants);
                    cmd.Parameters.AddWithValue("@isAvailable", currWorkshop.IsAvailable);
                    cmd.Parameters.AddWithValue("@isStarted", currWorkshop.IsStarted);
                    if (currWorkshop.Teacher != null)
                    {
                        cmd.Parameters.AddWithValue("@teacherPCN", currWorkshop.Teacher.Pcn);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@teacherPCN", null);
                    }

                    if (currWorkshop is OnsiteWorkshop)
                    {
                        cmd.Parameters.AddWithValue("@address", (currWorkshop as OnsiteWorkshop).Address);
                        cmd.Parameters.AddWithValue("@roomNr", (currWorkshop as OnsiteWorkshop).RoomNumber);
                        cmd.Parameters.AddWithValue("@url", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address", null);
                        cmd.Parameters.AddWithValue("@roomNr", null);
                        cmd.Parameters.AddWithValue("@url", (currWorkshop as OnlineWorkshop).Url);
                    }

                    DbConn.Open();

                    base.ExecuteNonQuery(cmd);
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentException ex)
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
            List<Workshop> workshops = new List<Workshop>();
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {
                    
                    string sql = "SELECT w.*, p.* from workshop as w " +
                                 "left join person as p " +
                                 "on w.TeacherPCN = p.Pcn";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);

                    

                    DbConn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        string title = dr[1].ToString();
                        string shortDescription = dr[2].ToString();
                        int capacity = Convert.ToInt32(dr[3]);
                        int nrOfParticipants = Convert.ToInt32(dr[4]);
                        bool isAvailable = Convert.ToBoolean(dr[5]);
                        bool isStarted = Convert.ToBoolean(dr[6]);
                        string teacherPCN = dr[7].ToString();
                        string address = dr[8].ToString();
                        string roomNr = dr[9].ToString();
                        string url = dr[10].ToString();

                        Person teacher = null;
                        if (teacherPCN != "")
                        {
                            string pcn = dr[11].ToString();
                            string fname = dr[12].ToString();
                            string lname = dr[13].ToString();
                            string email = dr[14].ToString();
                            string role = dr[15].ToString();
                            teacher = new Teacher(fname, lname, pcn, email, role);
                        }

                        Workshop currWorkshop;
                        if(url != "")
                        {
                            currWorkshop = new OnlineWorkshop(id, title, shortDescription, capacity,
                                nrOfParticipants, isAvailable, isStarted, teacher, url);
                        }
                        else
                        {
                            currWorkshop = new OnsiteWorkshop(id, title, shortDescription, capacity,
                                nrOfParticipants, isAvailable, isStarted, teacher, address, roomNr);
                        }
                        workshops.Add(currWorkshop);
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

            return workshops;
        }

        public override void Update(object obj)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {
                    Workshop currWorkshop = obj as Workshop;
                    string sql = "UPDATE workshop " +
                                 "set Title = @title, " +
                                 "ShortDescription = @shortDescription, " +
                                 "Capacity = @capacity, " +
                                 "NrOfParticipants = @nrOfParticipants, " +
                                 "IsAvailable = @isAvailable, " +
                                 "IsStarted = @isStarted, " +
                                 "TeacherPCN = @teacherPCN, " +
                                 "Address = @address, " +
                                 "RoomNr = @roomNr, " +
                                 "Url = @url " +
                                 "WHERE ID=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);
                    cmd.Parameters.AddWithValue("@id", currWorkshop.Id);
                    cmd.Parameters.AddWithValue("@title", currWorkshop.Title);
                    cmd.Parameters.AddWithValue("@shortDescription", currWorkshop.ShortDescription);

                    cmd.Parameters.AddWithValue("@capacity", currWorkshop.Capacity);
                    cmd.Parameters.AddWithValue("@nrOfParticipants", currWorkshop.NrOfParticipants);
                    cmd.Parameters.AddWithValue("@isAvailable", currWorkshop.IsAvailable);

                    cmd.Parameters.AddWithValue("@isStarted", currWorkshop.IsStarted);
                    if (currWorkshop.Teacher != null)
                    {
                        cmd.Parameters.AddWithValue("@teacherPCN", currWorkshop.Teacher.Pcn);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@teacherPCN", null);
                    }

                    if (currWorkshop is OnsiteWorkshop)
                    {
                        cmd.Parameters.AddWithValue("@address", (currWorkshop as OnsiteWorkshop).Address);
                        cmd.Parameters.AddWithValue("@roomNr", (currWorkshop as OnsiteWorkshop).RoomNumber);
                        cmd.Parameters.AddWithValue("@url", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Address", null);
                        cmd.Parameters.AddWithValue("@roomNr", null);
                        cmd.Parameters.AddWithValue("@url", (currWorkshop as OnlineWorkshop).Url);
                    }

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

        public override void Delete(object identifier)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {

                    string sql = "DELETE from workshop WHERE ID=@id";

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
