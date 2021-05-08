using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Models;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class PersonDbManager: DbAccess
    {
        public PersonDbManager(string dbConnectionStr) : base(dbConnectionStr)
        {
        }

        public override void Create(object obj)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {
                    Person currPerson = (Person)obj;
                    string sql = "INSERT into person(PCN, FirstName, LastName, Email, Role) " +
                                 "VALUES(@pcn, @fname, @lname, @email, @role)";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);

                    cmd.Parameters.AddWithValue("@pcn", currPerson.Pcn);
                    cmd.Parameters.AddWithValue("@fname", currPerson.Fname);
                    cmd.Parameters.AddWithValue("@lname", currPerson.Lname);
                    cmd.Parameters.AddWithValue("@email", currPerson.Email);
                    cmd.Parameters.AddWithValue("@role", currPerson.Role);
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
            List<Person> people = new List<Person>();
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {

                    string sql = "SELECT * from person";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);

                    DbConn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string pcn = dr[0].ToString();
                        string fname = dr[1].ToString();
                        string lname = dr[2].ToString();
                        string email = dr[3].ToString();
                        string role = dr[4].ToString();

                        Person currPerson;
                        if (role == "Student")
                        {
                            currPerson = new Student(fname, lname, pcn, email, role);
                        }
                        else
                        {
                            currPerson = new Teacher(fname, lname, pcn, email, role);
                        }
                        people.Add(currPerson);
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

            return people;
        }

        public override void Update(object obj)
        {
            try
            {
                using (DbConn = new MySqlConnection(base.DbConnectionStr))
                {
                    Person currPerson = obj as Person;

                    string sql = "UPDATE person " +
                                 "set FirstName = @fname, " +
                                 "LastName = @lname, " +
                                 "Email = @email, " +
                                 "Role = @role " +
                                 "WHERE Pcn=@pcn";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);
                    cmd.Parameters.AddWithValue("@pcn", currPerson.Pcn);
                    cmd.Parameters.AddWithValue("@fname", currPerson.Fname);
                    cmd.Parameters.AddWithValue("@lname", currPerson.Lname);

                    cmd.Parameters.AddWithValue("@email", currPerson.Email);
                    cmd.Parameters.AddWithValue("@role", currPerson.Role);
                    

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

                    string sql = "DELETE from person WHERE Pcn = @pcn";

                    MySqlCommand cmd = new MySqlCommand(sql, DbConn);
                    cmd.Parameters.AddWithValue("@pcn", identifier.ToString());

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
