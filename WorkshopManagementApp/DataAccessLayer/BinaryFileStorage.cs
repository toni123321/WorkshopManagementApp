using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataAccessLayer
{
    public abstract class BinaryFileStorage: FileStorage
    {

        protected BinaryFileStorage(string path) : base(path)
        {
        }

    }
}
