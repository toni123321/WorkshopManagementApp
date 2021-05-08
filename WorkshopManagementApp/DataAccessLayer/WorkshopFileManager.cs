using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class WorkshopFileManager: FileAccess
    {
        public WorkshopFileManager(string filename) : base(filename)
        {
        }

        public override void Create(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(object identifier)
        {
            throw new NotImplementedException();
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
    }
}
