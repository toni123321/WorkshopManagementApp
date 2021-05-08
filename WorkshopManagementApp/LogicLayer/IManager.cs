using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public interface IManager
    {
        void LoadDataFromStorage();
        bool Add(Object obj);
        bool Remove(Object identifier);
        bool Update(Object obj);
        Object GetObject(Object identifier);
        Object GetAllObjects();

    }
}
