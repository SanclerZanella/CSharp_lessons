/*
	In C#, there are different types of variables (defined with different keywords), for example:

    int - stores integers (whole numbers), without decimals, such as 123 or -123
    double - stores floating point numbers, with decimals, such as 19.99 or -19.99
    char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
    string - stores text, such as "Hello World". String values are surrounded by double quotes
    bool - stores values with two states: true or false
*/

//Root Library
using System;

// Used to organize your code, and it is a container for classes and other namespaces.
namespace Variables
{
	// Every app is contained in a class
	public class Program
	{
		// Every app has a Main() method
		public static void Main() // Main() method
		{
			// Declares a string variable to hold first name
			string firstName;
			firstName = "Sancler"; // Assign a value to firstName variable
			
			// Print out firstName Variable
			Console.Write(firstName);
			
			// Declares a string variable to hold lastName and assign a value
			string lastName = " Zanella";
			
			// Print out lastName Variable
			Console.WriteLine(lastName);
			
			// Declares a string variable to hold userName and assingn with user's name by input
			string userName = Console.ReadLine();
			
			// Print out userName Variable
			Console.WriteLine(userName);
			
			// Declares a int variable to hold age
			int age = 28;
			
			// String concatenation
			Console.WriteLine(firstName + lastName);
			Console.WriteLine("My age is:" + age);

            // Declares a int var to hold number
            int number = 10;
            const int num = 100; // const keyword prevents value for being changed
            // const int num1;  // const field must to be initialised at declaration 

            // String concatenation with operation
            Console.WriteLine("The Value of a number is: " + number);
            Console.WriteLine("The Value of a num is: " + num);
            Console.WriteLine("The Value of a number * 2 is: " + (number * 2));

            // Re-declare number var and print it out
            number = number + 5;
            // num = num + 1000; // Cannot change the value of a const var

            Console.WriteLine("The Value of a number is: " + number);
		}
	}
}