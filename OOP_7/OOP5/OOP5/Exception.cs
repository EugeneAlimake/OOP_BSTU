using System;
using System.Collections.Generic;
using System.Text;

namespace OOP5
{
    class DeleteException : Exception
    {
        public DeleteException(string msg) : base(msg) { }
    }

    class KashException : Exception
    {
        public KashException(string msg) : base(msg) { }
    }

    class MaxException : Exception
    {
        public MaxException(string msg) : base(msg) { }
    }
}
