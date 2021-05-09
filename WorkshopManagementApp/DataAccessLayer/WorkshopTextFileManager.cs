using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Models;

namespace DataAccessLayer
{
    public class WorkshopTextFileManager: TextFileStorage
    {
        public WorkshopTextFileManager(string path) : base(path)
        {
        }

        public override void Create(object obj)
        {
            List<Workshop> workshops = obj as List<Workshop>;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach (Workshop w in workshops)
                {
                    string noTeacherYetMsg = "Not selected";
                    
                    if (w is OnsiteWorkshop)
                    {
                        if (w.Teacher != null)
                        {
                            sw.WriteLine($"ONSITE(Title: {w.Title}, Description: {w.ShortDescription}, " +
                                         $"Teacher: {w.Teacher.Fname} {w.Teacher.Lname}, Capacity: {w.Capacity}, " +
                                         $"Location: {(w as OnsiteWorkshop).Address};{(w as OnsiteWorkshop).RoomNumber})");
                        }
                        else
                        {
                            sw.WriteLine($"ONSITE(Title: {w.Title}, Description: {w.ShortDescription}, " +
                                         $"Teacher: {noTeacherYetMsg}, Capacity: {w.Capacity}, " +
                                         $"Location: {(w as OnsiteWorkshop).Address};{(w as OnsiteWorkshop).RoomNumber})");
                        }
                    }
                    else
                    {
                        if (w.Teacher != null)
                        {
                            sw.WriteLine($"ONLINE(Title: {w.Title}, Description: {w.ShortDescription}, " +
                                         $"Teacher: {w.Teacher.Fname} {w.Teacher.Lname}, Capacity: {w.Capacity}, " +
                                         $"URL: {(w as OnlineWorkshop).Url})");
                        }
                        else
                        {
                            sw.WriteLine($"ONLINE(Title: {w.Title}, Description: {w.ShortDescription}, " +
                                         $"Teacher: {noTeacherYetMsg}, Capacity: {w.Capacity}, " +
                                         $"URL: {(w as OnlineWorkshop).Url})");
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing file");
            }
            finally
            { if (sw != null) { sw.Close(); } }
        }

        public override object Read(object identifier)
        {
            throw new NotImplementedException();
        }

        public override object ReadAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(object identifier)
        {
            throw new NotImplementedException();
        }
    }
}
