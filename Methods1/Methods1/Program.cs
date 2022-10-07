using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        private static void MethodA()
        {
            Console.WriteLine("I'm Method A");
            MethodB();
        }

        private static void MethodB()
        {
            Console.WriteLine("I'm Method B");
        }

    }
}
