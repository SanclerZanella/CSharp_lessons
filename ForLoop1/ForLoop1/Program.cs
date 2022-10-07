using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Syntax:
              for(initialize counter; condition; incrementer/decrementer)
              {
                // Code Block;
              }

              Initialization: Executed once, initialises a variable used to count
              the loop iterations;

              Condition: Defines the boolean expression to be evaluated.
                         If true: The code block is executed.
                                  The counter variables is incremented/decremented.
                                  The condition is re-evaluated and loop repeated.
                         If false: The loop terminates.

              Iterator: Executed after the code block, every time the code block runs.
                        Increments/Decrements the counter variable.

            */

            //Console.WriteLine("Print all number from 0 to 9.");
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\n\nPrint all number from 9 to 0.");
            //for (int b = 9; b > -1; b--)
            //{
            //    Console.WriteLine(b);
            //}

            //Console.WriteLine("\n\nSum the first 5 natural numbers");
            //int sum = 0;
            //for (int c = 1; c < 6; c++)
            //{
            //    sum += c;
            //}
            //Console.WriteLine($"Sum of the first 5 natural numbers is: {sum}");

            //Console.WriteLine("\n\nPrint the Fibonacci Series");
            //int n1 = 0, n2 = 1, n3, i, digits=15;
            //Console.Write($"{n1} {n2} ");
            //for (i = 2; i < digits; ++i)
            //{
            //    n3 = n1 + n2; 
            //    Console.Write($"{n3} ");
            //    n1 = n2;
            //    n2 = n3;
            //}

            //int z = 0;
            //for(; z < 10; )
            //{
            //    Console.WriteLine(z);
            //    z++;
            //}

            //Console.WriteLine("Nested for loops.");
            //for(int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine($"Outer loop iteration {j}");
            //    for (int k = 0; k < 10; k++)
            //    {
            //        if(j == k)
            //        {
            //            Console.WriteLine($"Inner loop iteration {k}");
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("\n\nCreate a letter 'A' pattern using a nested for loop");
            //int row, column;

            //for(row = 0; row <= 7; row++)
            //{
            //    for (column = 0; column <= 7; column++)
            //    {
            //        if (((column == 1 || column == 5) && row != 0))
            //        {
            //            Console.Write("#");
            //        }
            //        else if ( (column == 3 || column == 2 || column == 4) && row == 0)
            //        {
            //            Console.Write("#");
            //        }
            //        else if (row == 4 && (column == 3 || column == 2 || column == 4))
            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.Write("\n");

            //}

            //for (row = 0; row <= 7; row++)
            //{
            //    for (column = 0; column <= 7; column++)
            //    {
            //        if ( ( (row == 0 || row == 4) && (column == 2 || column == 3 || column == 4) ) || (row != 0 && (column == 1 || column == 5) ) )
            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.Write("\n");

            //}

            Console.WriteLine("\n\nCreate a pyramid using a nested for loop, display with asterisk, the pyramid should be 9 rows high.\n");
            //int row, column;
            //for (row = 0; row <= 9; row++)
            //{

            //    for (column = 0; column <= row; column++)
            //    {
            //        if (row == 0 && column == 10)
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 0 && row <= 1) && (column >= 9 && column <= 11))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 1 && row <= 2) && (column >= 8 && column <= 12))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 2 && row <= 3) && (column >= 7 && column <= 13))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 3 && row <= 4) && (column >= 6 && column <= 14))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 4 && row <= 5) && (column >= 5 && column <= 15))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 5 && row <= 6) && (column >= 4 && column <= 16))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 6 && row <= 7) && (column >= 3 && column <= 17))
            //        {
            //            Console.Write("*");
            //        }
            //        else if ((row > 7 && row <= 8) && (column >= 2 && column <= 18))
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }

            //    Console.Write("\n");
            //}

            int sleepTime = 100;
            int r, c, h = 9; // r = row, c = column and h = height

            for (r = 0; r <= h; r++) // Prints rows while the number of rows are less than or equal the height
            {
                for (c = 0; c <= h - r; c++) // Prints space while column is less than the diference between the height and the current row
                {
                    Thread.Sleep(sleepTime);
                    Console.Write(c);
                }

                for (c = 0; c <= 2*r; c++) // Prints stars while column is twice current row minus 1
                {
                    Thread.Sleep(sleepTime);
                    Console.Write("*");
                }

                Console.Write("\n");
            }

        }
    }
}
