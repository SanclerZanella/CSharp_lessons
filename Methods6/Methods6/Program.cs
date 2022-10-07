using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            int b = 54;
            int c = 17;
            int d = 109;
            decimal e = 5.99m;
            decimal f = 72.3m;

            Console.WriteLine(Sum(a, b));

            Console.WriteLine(Sum(a, b, c));

            Console.WriteLine(Sum(a, b, c, d));

            Console.WriteLine(Sum(e, f));

        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static decimal Sum(decimal e, decimal f)
        {
            return e + f;
        }
    }
}
