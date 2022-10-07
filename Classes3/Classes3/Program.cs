using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car();
            Console.WriteLine(c1.WhatAmI());

            Console.WriteLine("\n");

            Bus b1 = new Bus();
            Console.WriteLine(b1.WhatAmI());

            Console.WriteLine("\n");


        }
    }
}
