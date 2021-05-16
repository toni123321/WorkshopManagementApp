using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Models;

namespace DataAccessLayer
{
    public class WorkshopBinaryFileManager: BinaryFileStorage
    {
        public WorkshopBinaryFileManager(string path) : base(path)
        {
        }

        public override void Create(object obj)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            List<Workshop> workshops = new List<Workshop>();
            Workshop currWorkshop = obj as Workshop;
            workshops.Add(currWorkshop);
            try
            {
                fs = new FileStream(Path, FileMode.Append, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                bf = new BinaryFormatter();

                bf.Serialize(fs, workshops);

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Chosen file is not found!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public override object Read(object identifier)
        {
            throw new NotImplementedException();
        }

        public override object ReadAll()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            List<Workshop> workshops = new List<Workshop>();

            try
            {
                fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);
                bf = new BinaryFormatter();

                if (fs.Length > 0)
                {
                    workshops = (List<Workshop>)bf.Deserialize(fs);
                    
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Chosen file is not found!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return workshops;
        }

        public override void Update(object obj)
        {
            List<Workshop> workshops = this.ReadAll() as List<Workshop>;
            FileStream fs = null;
            BinaryFormatter bf = null;

            Workshop currWorkshop = obj as Workshop;

            try
            {
                fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write);
                bf = new BinaryFormatter();
                
                //workshops = (List<Workshop>)bf.Deserialize(fs);
                
                int indexCurrWorkshop = workshops.
                    FindIndex(w => w.Id == currWorkshop.Id);
                workshops[indexCurrWorkshop] = currWorkshop;
                
                //TODO: Serialize list of workshops and save it back in the file
                bf.Serialize(fs, workshops);
                
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Chosen file is not found!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to the file!");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public override void Delete(object identifier)
        {
            List<Workshop> workshops = this.ReadAll() as List<Workshop>;
            FileStream fs = null;
            BinaryFormatter bf = null;

            string id = identifier.ToString();
            try
            {
                fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write);
                bf = new BinaryFormatter();
                
                //workshops = (List<Workshop>)bf.Deserialize(fs);
                int indexCurrWorkshop = workshops.
                    FindIndex(w => w.Id == id);
                workshops.RemoveAt(indexCurrWorkshop);
                bf.Serialize(fs, workshops);
                
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Chosen file is not found!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to the file!");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
