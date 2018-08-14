using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P6_CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");

            Garage garage = new Garage();
            // Hand over each car in the collection?
            foreach (Car c in garage)
            {
                Console.WriteLine("{0} is going {1} MPH", c.CarName, c.CurrentSpeed);
            }
            Console.ReadLine();
        }
    }
}
