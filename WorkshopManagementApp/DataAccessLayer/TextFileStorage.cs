using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccessLayer
{
    public abstract class TextFileStorage: FileStorage
    {
        

        protected TextFileStorage(string path) : base(path)
        {
        }
    }
}
