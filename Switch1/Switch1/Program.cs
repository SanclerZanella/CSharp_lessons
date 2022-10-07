using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Switch1
{
    internal class Program
    {
        static void Main()
        {
            //int day = 1;
            int day = 3;
            //int day = 7;
            //int day = 8;

            //if (day == 1)
            //{
            //    Console.WriteLine("Today is Monday!");
            //}
            //else if (day == 2)
            //{
            //    Console.WriteLine("Today is Tuesday!");
            //}
            //else if (day == 3)
            //{
            //    Console.WriteLine("Today is Wednesday!");
            //}
            //else if (day == 4)
            //{
            //    Console.WriteLine("Today is Thursday!");
            //}
            //else if (day == 5)
            //{
            //    Console.WriteLine("Today is Friday!");
            //}
            //else if (day == 6)
            //{
            //    Console.WriteLine("Today is Saturday!");
            //}
            //else if (day == 7)
            //{
            //    Console.WriteLine("Today is Sunday!");
            //}
            //else 
            //{
            //    Console.WriteLine("Day not Recognised!");
            //}

            /*
              The switch statement gets the value of a variable and matches it to the value
              of its case attributes. The codeblock in the matching case is the run.
              The break keyword then breaks the cycle out of the switch.
              A default block can be used to execute code if no case was matched. This is optional.
              The switch expression is only evaluated once.
            */
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Monday!");
                    break;

                case 2:
                    Console.WriteLine("Today is Tuesday!");
                    break;

                case 3:
                    Console.WriteLine("Today is Wednesday!");
                    break;

                case 4:
                    Console.WriteLine("Today is Thursday!");
                    break;

                case 5:
                    Console.WriteLine("Today is Friday!");
                    break;

                case 6:
                    Console.WriteLine("Today is Saturday!");
                    break;

                case 7:
                    Console.WriteLine("Today is Sunday!");
                    break;

                default:
                    Console.WriteLine("Day not Recognised!");
                    break;
            }

        }
    }
}
