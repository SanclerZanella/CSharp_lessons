using System;
					
public class Program
{
	public static void Main()
	{
		int a = 10;
		int b = 10;
		
		if(a > b) {
			Console.WriteLine($"a ({a}) is greater than b ({b})");
		}
		else if(a < b) {
			Console.WriteLine($"a ({a}) is less than b ({b})");
		}
		else if(a == b) {
			Console.WriteLine($"a ({a}) is equal to b ({b})");
		}
		else {
			Console.WriteLine($"a ({a}) is not greater than or less than b ({b})");
		}
		
		Console.WriteLine("\n\nEnd");
	}
}