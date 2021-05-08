using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataAccessLayer
{
    public abstract class FileAccess: IStorageAccess
    {
        private FileStream fs;
        private BinaryFormatter bf;

        public string Filename
        {
            get;
            set;
        }

        protected FileAccess(string filename)
        {
            Filename = filename;
        }


        public abstract void Create(object obj);

        public abstract object Read(object identifier);

        public abstract object ReadAll();

        public abstract void Update(object obj);

        public abstract void Delete(object identifier);
    }
}
