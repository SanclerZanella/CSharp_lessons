/*
	int myNum = 5;               // Integer (whole number)
	double myDoubleNum = 5.99D;  // Floating point number
	char myLetter = 'D';         // Character
	bool myBool = true;          // Boolean
	string myText = "Hello";     // String
*/

//Root Library
using System;

// Used to organize your code, and it is a container for classes and other namespaces.
namespace dataTypes
{
	// Every app is contained in a class
	public class Program
	{
		// Every app has a Main() method
		public static void Main() // Main() method
		{
			//int var
			int x = 5;
			Console.WriteLine("x = " + x);
			// re assign x
			x = 100;
			Console.WriteLine("x = " + x);
			
			// long y = 2_147_483_647l; // long var with underscore notation
			
			// int var with sum operation
			int z = 5 + 5;
			Console.WriteLine("z = " + z);
			
			// double var
			double height = 1.50;
			double width = 5;
			Console.WriteLine("height = " + height);
			Console.WriteLine("width = " + width);
			
			double area = height * width;
			Console.WriteLine("area = " + area);
			
			// byte var
			byte age = 255;
			Console.WriteLine("age = " + age);
			
			// String interpolation
			string fname = "Sancler";
			string lname = "Zanella";
			Console.WriteLine($"My full name is: {fname} {lname}");

            // String interpolation
			string fname = "Sancler";
			string lname = "Zanella";
			Console.WriteLine($"My full name is: {fname} {lname}");
			
			string fullName = $"{fname} {lname}";
			
			// String methods
			int x = fullName.Length;
			Console.WriteLine($"The length of fullName: {x} ");
			
			Console.WriteLine(fullName.ToUpper());
			Console.WriteLine(fullName.ToLower());
			Console.WriteLine(fullName.Substring(1, (fullName.Length - 1) ));
		}
	}
}
