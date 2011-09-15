using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.ErrorHandling
{
    public class CannotInheritFromVertexException : Exception
    {
        public String Message;

        public CannotInheritFromVertexException(String myMessage)
        {
            Message = myMessage;
        }
    }
}
