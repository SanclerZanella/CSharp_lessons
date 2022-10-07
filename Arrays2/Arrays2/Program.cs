using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Declare an array of strings.
            //string[] words = {"Cat", "banana", "bike"};

            //// Declare an array of doubles.
            //double[] doubles = { 4, 2.5, 6.309 };

            //// Declare an array of chars.
            //char[] chars = { 'A', 'b', 'C', '3', '@'};

            // Ask the user for a sentence.
            Console.WriteLine("Enter your sentence here:");
            string sentence = Console.ReadLine();

            // Convert the sentence to an array of characters.
            char[] sentenceChars = sentence.ToCharArray();

            //for(int a = 0; a < sentenceChars.Length; a++)
            //{
            //    Console.WriteLine(sentenceChars[a]);
            //}

            //for (int b = sentenceChars.Length - 1; b < - 1; b--)
            //{
            //    Console.WriteLine(sentenceChars[b]);
            //}

            // foreach loop

            int index = 0;
            foreach (char c in sentenceChars)
            {
                Console.WriteLine($"Value at loop iteration: {index} is: {c}");
                index++;
            }

            Console.WriteLine("\nd\n");
            int d = 1;
            Console.WriteLine(d); // 1
            Console.WriteLine(d++); // 1 Incremented after.
            Console.WriteLine(d); // 2

            Console.WriteLine("\ne\n");
            int e = 1;
            Console.WriteLine(e); // 1
            Console.WriteLine(++e); // 2 Incremented before.
            Console.WriteLine(e); // 2

        }
    }
}
