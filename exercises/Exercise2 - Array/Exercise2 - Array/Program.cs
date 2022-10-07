/*
    int[]arr1 = {5, 6, 9};
    int[]arr2 = {6, 8, 5};
    int[] arrRes = new int[2];

    Loop through arr1 and arr2, and find their unique values.
    Place the unique values into arrRes and output its contents.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int arrays
            int[] arr1 = { 5, 6, 9 };
            int[] arr2 = { 6, 8, 5 };

            // Array with answers
            int[] arrRes = new int[2];

            // Iteration Through the arr1 and arr2
            // Iterate through the arr1
            foreach (int arr1El in arr1)
            {
                // Contains is a method to check if a specified value is in an array
                if (!(arr2.Contains(arr1El)))
                {
                    // SetValue is a method to add value to an empty array
                    arrRes.SetValue(value: arr1El, index: 0);
                }
            }

            // Iterate through the arr2
            foreach (int arr2El in arr2)
            {
                if (!(arr1.Contains(arr2El)))
                {
                    arrRes.SetValue(value: arr2El, index: 1);
                }
            }

            // Sort arrRes to put the answers in order
            Array.Sort(arrRes);

            // Iterate through arrRes and print out its elements
            Console.WriteLine("\nThe unique values are:");
            foreach (int arrResEl in arrRes)
            {
                Console.WriteLine(arrResEl);
            }

        }
    }
}
