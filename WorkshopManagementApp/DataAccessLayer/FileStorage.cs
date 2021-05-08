using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public abstract class FileStorage: IStorage
    {
        public string Path
        {
            get;
            set;
        }

        protected FileStorage(string path)
        {
            Path = path;
        }

        public abstract void Create(object obj);

        public abstract object Read(object identifier);

        public abstract object ReadAll();

        public abstract void Update(object obj);

        public abstract void Delete(object identifier);
        
    }
}
