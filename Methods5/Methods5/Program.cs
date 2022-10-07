using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    internal class Program
    {

        static bool CompareNums(int a, int b)
        {
            bool isEqual = false;
            if (a == b)
            {
                isEqual = true;
            }
            else if (a != b)
            {
                isEqual = false;
            }

            return isEqual;
        }

        static void Main(string[] args)
        {

            int a = 10;
            int b= 20;

            bool is_equal = CompareNums(a, b);

            if(is_equal)
            {
                Console.WriteLine("a and b are equal.");
            }
            else 
            {
                Console.WriteLine("a and b are not equal.");
            }

        }

    }
}
