using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                MessageBox.Show(ex.Message);
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
            /*List<Workshop> workshops = new List<Workshop>();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string workshopType = line.Split('(')[0];
                    string objectString = line.Split('(')[1].Split(')')[0];

                    string[] words = objectString.Split(',');
                    int strBeforeValueIndex;
                    int substringLength;
                    for (int i = 0; i < words.Length; i++)
                    {
                        
                        if (i == 0)
                        {
                            strBeforeValueIndex = words[i].IndexOf(' ');
                            substringLength = words[i].Length - strBeforeValueIndex - 1;
                            words[i] = words[i].Substring(strBeforeValueIndex + 1, substringLength);
                        }
                        else
                        {
                            strBeforeValueIndex = words[i].IndexOf(' ');
                            substringLength = words[i].Length - strBeforeValueIndex - 1;
                            words[i] = words[i].Substring(strBeforeValueIndex + 1, substringLength);

                            strBeforeValueIndex = words[i].IndexOf(' ');
                            substringLength = words[i].Length - strBeforeValueIndex - 1;
                            words[i] = words[i].Substring(strBeforeValueIndex + 1, substringLength);
                        }
                    }

                    Workshop workshop;
                    if (workshopType.ToLower() == "onsite")
                    {
                        
                        workshop = new OnsiteWorkshop(words[0], words[1], words[2], 
                            words[3], words[5], words[6]);

                    }

                    //workshops.Add(workshop);
                }
                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { if (sr != null) { sr.Close(); } }

            return workshops;*/
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
