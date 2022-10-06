using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter the first number and press enter:");
		string a = Console.ReadLine();
		
		Console.WriteLine("Enter the second number and press enter:");
		string b = Console.ReadLine();
		
		//int x = Convert.ToInt32(a);
		
		//int y = Int32.Parse(b);
		
		//Console.WriteLine(x);
		//Console.WriteLine(y);
		
		if(decimal.TryParse(a, out decimal x))
		{
			Console.WriteLine($"a({a}) parsed to x: {x}");
		}
		else
		{
			Console.WriteLine($"a({a}) cannot be parsed to an integer");
		}
		
		if(decimal.TryParse(b, out decimal y))
		{
			Console.WriteLine($"b({b}) parsed to y: {y}");
		}
		else
		{
			Console.WriteLine($"b({b}) cannot be parsed to an integer");
		}
		
		// Sum
		decimal res = x + y;
		Console.WriteLine($"{x} + {y} = {res}");
		
		// Subtraction
		res = x - y;
		Console.WriteLine($"{x} - {y} = {res}");
		
		// Multiplication
		res = x * y;
		Console.WriteLine($"{x} * {y} = {res}");
		
		// Division
		if(x >= y) {
			res = x / y;
			Console.WriteLine($"{x} / {y} = {res}");
		}
		else if(x < y) {
			res = x / y;
			Console.WriteLine($"{x} / {y} = {res}");
		}
		else {
			Console.WriteLine("Division did not work!");
		}
		
		// Remainder
		res = x % y;
		Console.WriteLine($"{x} % {y} = {res}");
		
		//try
        //{
           // int m = Int32.Parse("abc");
        //}
        //catch (Exception e)
        //{
            //Console.WriteLine(e.Message);
        //}
		
	}
}