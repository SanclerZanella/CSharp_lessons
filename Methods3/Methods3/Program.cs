using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int sum = Sum(a, b);
            int sub = Sub(a, b);
            int mult = Mult(a, b);
            Console.WriteLine($"The sum of a ({a}) and b ({b}) is: {sum}");
            Console.WriteLine($"The subtraction of a ({a}) and b ({b}) is: {sub}");
            Console.WriteLine($"The multiplication of a ({a}) and b ({b}) is: {mult}");
        }

        static int Sum(int a, int b)
        {
            int result;

            if(a == b)
            {
                result = a * 2;
            }
            else
            {
                result = a + b;
            }

            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }
    }
}
