using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 10; i++)
            {

                if (i == 5)
                    continue; // The continue operator lets us skip the rest of the codes block and jump
                             // to the next iteration loop.

                Console.WriteLine(i);

                if (i == 8)
                    break; // Stop the loop.

            }

        }
    }
}
