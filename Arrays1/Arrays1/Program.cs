using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 1;

          // type[] name = {element values};
            int[] numbers1 = {1, 2, 3, 4, 5}; // Declaring array and assigning values on same line.
            int[] numbers2 = new int[] {1, 2, 3, 4, 5}; // Declaring array and assigning values on same line.
            int[] numbers3 = new int[5] {1, 2, 3, 4, 5}; // Declaring array and assigning values on same line.
            int[] numbers4 = new int[5]; // Empty array.

            int[] numbers5; // Empty array.
            numbers5 = new int[] { 1, 2, 3, 4, 5 }; // Assigning values to numbers5 array. 

            Console.WriteLine(numbers1);
            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers1[1]);
            Console.WriteLine(numbers1[2]);
            Console.WriteLine(numbers1[3]);
            Console.WriteLine(numbers1[4]);

            int length = numbers1.Length;
            Console.WriteLine($"\n\nThe length of the numbers array is: {length}\n");

            // Change elements value
            numbers1[0] = 15;
            numbers1[1] = 20;
            numbers1[2] = 25;
            numbers1[3] = 30;
            numbers1[4] = 35;
            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers1[1]);
            Console.WriteLine(numbers1[2]);
            Console.WriteLine(numbers1[3]);
            Console.WriteLine(numbers1[4]);

            int sumDLongWay = numbers1[0] + numbers1[1] + numbers1[2] + numbers1[3] + numbers1[4];
            Console.Write($"\n\nSum longway: {sumDLongWay}\n\n");

            for (int index = 0; index < numbers1.Length; index++)
            {
                Console.Write(numbers1[index] + ",");
            }

            int sum = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                sum += numbers1[i];
            }
            Console.Write($"\n\nThe sum of all the elements in the numbers array is: {sum}\n");

        }
    }
}
