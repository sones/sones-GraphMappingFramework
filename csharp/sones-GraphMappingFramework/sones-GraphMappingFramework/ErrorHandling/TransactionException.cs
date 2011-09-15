using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.ErrorHandling
{
    public class TransactionException : Exception
    {
        public String Message;

        public TransactionException(String myMessage)
        {
            Message = myMessage;
        }
    }
}
