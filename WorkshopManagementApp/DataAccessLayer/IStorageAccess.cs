using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IStorageAccess
    {
        void Create(Object obj);
        Object Read(Object identifier);
        Object ReadAll();
        void Update(Object obj);
        void Delete(Object identifier);

    }
}
