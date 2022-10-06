/*
Write a program that print's multiplication tables.

1. Ask the user for a number.

2. Verify the user has provided a valid number.

4. Use the number to output the multiplication table (range 0 to 12 times multiplication).
	e.g.	<number> x 0 = <result>
		<number> x 1 = <result>
		<number> x 2 = <result>
		<number> x 3 = <result>
		<number> x 4 = <result>
		<number> x 5 = <result>
		<number> x 6 = <result>
		<number> x 7 = <result>
		<number> x 8 = <result>
		<number> x 9 = <result>
		<number> x 10 = <result>
		<number> x 11 = <result>
		<number> x 12 = <result>
*/

using System;
					
public class Program
{
	public static void Main()
	{
		//Execute program while don't take the exactly input from the user
		while(true)
		{
			// Get user's input as string
			Console.WriteLine("\nPlease, inform the multiplier:\n");
			string multiplier = Console.ReadLine();

			// Checks if user's input can be converted to an integer
			try 
			{
				// If so convert input to integer
				int x = Int32.Parse(multiplier);
				
				// Define first multiplicand being zero
				int multiplicand = 0;
				
				// Execute code while multiplicand is less than or equal to 12
				while(multiplicand <= 12)
				{
					// Print multiplication result on the console
					Console.WriteLine($"{x} x {multiplicand} = {x * multiplicand}");
					
					// Increments multiplicand until reach 12
					multiplicand++;
				}
				
			}
			// Catch exception in case user don't provide a number as input
			catch( Exception e)
			{
				// Ask the user to provider a number and go to the start of the code
				Console.WriteLine($"\n{e.Message} - Please, inform a NUMBER.");
			}
			
			// LoopMiddle label
			LoopMiddle:
				Console.Write("\nWould you like to continue? (y/n)\n");
			string ans = Console.ReadLine();

			if(ans == "y")
			{
				// Go to the start of the code
				continue;
			}
			else if(ans == "n")
			{
				// Finish loop and program
				Console.WriteLine("\nShutting down the program");
				break;
			}
			else
			{
				// Directs code flow to the LoopMiddle label.
				Console.WriteLine("\nPlease use just 'y' or 'n' as answer");
				goto LoopMiddle;
			}
			
		}
		
	}
}