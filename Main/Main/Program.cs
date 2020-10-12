using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

using System.Text.Json;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {


            var pitsa = new Pitsa("Pepperoni", 33.5);
            string jsonsered = Serialize(pitsa);
            Console.WriteLine(jsonsered);

            Console.ReadKey();

            var fuckUpPitsa = new Pitsa("Margarita", 50);
            string failedJsonsered = Serialize(fuckUpPitsa);
        }

        public static string Serialize(Pitsa obj)
        {

            Type type = typeof(Pitsa);
            object[] attrs = type.GetCustomAttributes(false);
            foreach (PitsaValidationAttribute attr in attrs)
            {
                if (obj.Radius <= attr.Radius)
                {
                    return JsonSerializer.Serialize(obj);

                }
                throw new CustomInvalidToAttributeException("Pitsa can not be more than 40 cm in radius", obj.Radius);

            }
            return null;
        }
    }
}
