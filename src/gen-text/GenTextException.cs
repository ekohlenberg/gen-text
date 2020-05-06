using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataventure.gentext.util
{
    public class GenTextException : Exception
    {
        public GenTextException():base()
        {
        }

        public GenTextException(string message):base(message)
        {
        }

        public GenTextException(string message, Exception inner):base(message, inner)
        {
        }

        public GenTextException(Type t, string message) : base(t.Name + ": " + message)
        {
        }

        public GenTextException(Type t, string message, Exception inner) : base(t.Name + ": " + message, inner)
        {
        }
    }
}
