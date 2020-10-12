using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class PitsaValidationAttribute : System.Attribute
    {
        public double Radius { get; set; }
        public PitsaValidationAttribute(double radius)
        {
            Radius = radius;
        }
    }
}
