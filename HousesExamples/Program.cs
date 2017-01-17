using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();
            // new house object
            house1.Paint("Green");
            Console.WriteLine(house1.CurrentColor());

            house1.Paint("White");
            Console.WriteLine(house1.CurrentColor());

            House house2 = new House();
            house2.Paint("Blue");

            Console.WriteLine("House one is: " + house1.CurrentColor());
            Console.WriteLine("House two is: " + house2.CurrentColor());





        }
    }
}
