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


            var pitsa = new Pitsa("Pepperoni", 33.5, 2);


            Console.ReadKey();

            var burrito = new Burrito("Mexican Hell", 50, true);

            Serialization.Serialize(pitsa, "pitsa.json");

           

            try
            {
                Serialization.Serialize(burrito, "burrito.json");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


    }
}
