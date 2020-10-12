using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class CustomIgnoreAttribute : System.Attribute
    {
        public CustomIgnoreAttribute()
        {

        }
    }

        [Serializable]
        public abstract class Food
        {
            [CustomIgnoreAttribute]
            public string Name { get; set; }

            [CustomIgnore]
            public double Weight { get; set; }

            public Food()
            {

            }

            public Food(string name, double weight)
            {
                Name = name;
                Weight = weight;
            }
        }


    [Serializable]
    public class Pitsa : Food
    {
        public uint Size { get; set; }

        public Pitsa(string name, double weight, uint size)
            : base(name, weight)
        {
            Size = Size;
        }
    }

    [Serializable]
    public class Burrito : Food
    {
        public bool IsSpicy { get; set; }

        public Burrito(string name, double weight, bool isSpicy)
            : base(name, weight)
        {
            IsSpicy = isSpicy;
        }

    }
}

    

