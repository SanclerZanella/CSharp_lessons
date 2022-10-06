using System;
					
public class Program
{
	public static void Main()
	{
		string name = "Banana";
		double price = 0.95;
		
		// 1
		Console.WriteLine("The " + name + " is $" + price.ToString() + "c");
		
		// 2
		string message = "The " + name + " is $" + price.ToString() + "c";
		Console.WriteLine(message);
		
		// 3
		string message2 = string.Format("The {0} is {1:C}", name, price);
		Console.WriteLine(message2);
		
	}
}