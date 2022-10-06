/*
    Use If/Else If/Else statements as required to do the following:
    Find the largest of 2 numbers.
	(Ask the user for the 2 numbers).
*/

using System;
					
public class Program
{
	public static void Main()
	{
		//Execute program while don't take the exactly input from the user
		while(true)
		{
			// ProgramStart label
			ProgramStart:
				Console.WriteLine("\nPick your first number?!\n");
			
			// Get user's first number
			string firstNumber = Console.ReadLine();
			
			// Get user's second number
			Console.WriteLine("\nPick your second number?!\n");
			string secondNumber = Console.ReadLine();
			
			// Check if user's first input is a number
			try
			{
				// if so parse the first input to an integer
				int intFirstNumber = Int32.Parse(firstNumber);
				
				// if so parse the second input to an integer
				int intSecondNumber = Int32.Parse(secondNumber);

				if(intFirstNumber > intSecondNumber)
				{
					// Check if the first number is larger than the second number
					Console.WriteLine($"\nThe first number ({intFirstNumber}) is larger than the second number ({intSecondNumber})\n");
				}
				else if(intFirstNumber < intSecondNumber)
				{
					// Check if the second number is larger than the first number
					Console.WriteLine($"\nThe second number ({intSecondNumber}) is larger than the first number ({intFirstNumber})\n");
				}
				else
				{
					// Check if the numbers are equal
					Console.WriteLine("\nThe numbers are equal!\n");
				}
				
			}
			catch(Exception e)
			{
				// Ask the user to provider a number and go to the start of the code
				Console.WriteLine($"\n{e.Message} - Please inform a NUMBER\n");
				goto ProgramStart;
			}
			
			ProgramEnd:
			// Ask if the user wants to continue executing the program
				Console.Write("\nWould you like to continue? (y/n)\n");
			
			string ans = Console.ReadLine();

			// Check if answer is 'y' or 'no'
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
				// Directs code flow to the ProgramEnd label.
				Console.WriteLine("\nPlease use just 'y' or 'n' as answer");
				goto ProgramEnd;
			}
			
		}
		
	}
}