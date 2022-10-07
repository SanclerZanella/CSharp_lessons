using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 0; i < 10; i++)
            //{ 
            //    Console.WriteLine(i);
            //}

            int w = 1;
            while (w < 10)
            {
                Console.WriteLine(w);
                w++;
            }

            bool keepRunning = true;

            while(keepRunning)
            {
                Console.WriteLine("Running.............");
                keepRunning = false;
            }
            Console.WriteLine("Not Running anymore.");

            Console.WriteLine("\n\nDo while loop:\n");
            int a = 10;

            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 10);

            bool doRun = false;

            do
            {
                Console.WriteLine("\n\ndoRun is " + doRun + "\n");
            }
            while(doRun);
        }
    }
}
