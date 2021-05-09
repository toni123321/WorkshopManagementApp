using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions
{
    public class InputFieldException: Exception
    {
        public InputFieldException(string msg): 
            base($"{msg}")
        {
            
        }
    }
}
