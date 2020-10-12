using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class NoAvailablePropertiesException : Exception
    {
        

        public NoAvailablePropertiesException()
            : base(String.Format("There are no properties for serialization"))
        {

        }
    }
}