/*
    Create an arry to hold the days of the week.
        Task 1: Output what day today is;
        Task 2: Use a while loop to output all of the days except 'Wednesday'.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare an array of strings for the days of week.
            string[] days_of_week = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            // Print out which day is today
            Console.WriteLine("\nToday is: " + days_of_week[3] + "\n");

            // Get the days index, starting by the first index
            int days_index = 0;

            // Iterate through the days_of_week array
            while (days_index < days_of_week.Length)
            {

                // If days_of_week[days_index] is 'Wednesday', skip it
                if (days_of_week[days_index] == "Wednesday")
                {

                    // Increment days_index var before skip 'Wednesday'
                    days_index++;

                    continue;

                }

                // Print all the elements in the days_of_week array, less the element 3 (Wednesday)
                Console.WriteLine(days_of_week[days_index] + "\n");

                // Increment days_index var
                days_index++;
            }

            string[] arr1 = {"Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun"};
            string[] arr2 = {"Jan", "Zulu", "Feb", "Mar", "Alpha", "Omega"};

            Console.WriteLine("Original arr1");
            foreach(string a1 in arr1)
            {
                Console.WriteLine(a1);
            }
            Console.WriteLine("\nOriginal arr2\n");
            foreach (string a2 in arr2)
            {
                Console.WriteLine(a2);
            }

            //Array.Sort(arr2);
            //Array.Reverse(arr2);

            //Array.Resize(ref arr1, 8);
            //Array[7] = "Spagetti";

            //Array.Clear(arr1, 0, arr1.Length);
            //Array.Clear(arr1, 1, arr1.Length -1);
            //Array.Clear(arr1, 0, arr1.Length -1);


            Console.WriteLine("\nChange arr2\n");
            foreach (string a2 in arr2)
            {
                Console.WriteLine(a2);
            }

        }
    }
}
