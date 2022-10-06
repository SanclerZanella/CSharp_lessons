/*
	First Class - L5 OOP C#

	This is a multi-line comment
*/

//Root Library
using System;

// Used to organize your code, and it is a container for classes and other namespaces.
namespace BasicCliApp
{

	// Every app is contained in a class
	public class Program
	{
		// Every app has a Main() method
		public static void Main() // Main() method
		{
			// Algorithm

			// WriteLine Jumps Line when printed
			Console.WriteLine("Hello World");

			// Write does not Jump Line when printed
			Console.Write("This is the first part of our sentence");
			Console.Write("and this is the second part of our sentence");

			// Single Quotation used inside strings
			Console.WriteLine("Console 'app' 2 Demo");

			// Backslash to validate double quotation inside a string
			Console.WriteLine("Console \"app\" 2 Demo");

			// Backslash to tab space inside a string
			Console.WriteLine("This is a tab\tspace");

			// Backslash to jump line inside a string
			Console.WriteLine("This is sentance\non 2 lines");

			// Single quotation for characters
			Console.WriteLine('C');

			// Commented line code vvv
			// Console.WriteLine(3);

			Console.ReadLine();


		}
	}
	
}
