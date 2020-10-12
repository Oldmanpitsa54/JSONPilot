using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class CustomInvalidToAttributeException : ArgumentOutOfRangeException
    {
        public double Value { get; }
        public CustomInvalidToAttributeException(string message, double val)
            : base(message)
        {
            Value = val;
        }

    }
}
