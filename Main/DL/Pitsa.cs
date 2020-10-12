using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    [PitsaValidation(40)]
    public class Pitsa
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public Pitsa(string name, double rad)
        {
            Name = name;
            Radius = rad;
        }
    }
}
