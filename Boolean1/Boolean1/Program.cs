using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            x = 10;
            y = 5;

            Console.WriteLine($"\nIs {x} greater than to {y}?");
            Console.WriteLine(x > y);

            Console.WriteLine($"\nIs {x} less than to {y}?");
            Console.WriteLine(x < y);

            Console.WriteLine($"\nIs {x} greater than or equal to {y}?");
            Console.WriteLine(x >= y);

            Console.WriteLine($"\nIs {x} less than or equal to {y}?");
            Console.WriteLine(x <= y);

            Console.WriteLine($"\nIs {x} equal to {y}?");
            Console.WriteLine(x == y);

            Console.WriteLine($"\nIs {x} not equal to {y}?");
            Console.WriteLine(x != y);
            Console.WriteLine(!(x == y));


            //Console.ReadLine();
        }
    }
}
