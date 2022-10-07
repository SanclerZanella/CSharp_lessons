using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Switch off the lights";
            int spaces = GetNumSpacesFromString(sentence);
            Console.WriteLine($"The sentence '{sentence}' has {spaces} blank spaces.");
        }

        static int GetNumSpacesFromString(string sentence)
        {
            /*
                Create a method that take a parameter of type string and returns a result of type int
                Where the result is the number of spaces in the string.
            */

            string[] arr = sentence.Split(' ');

            return arr.Length - 1;
        }
    }
}
