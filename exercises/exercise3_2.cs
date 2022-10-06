/*
    Use If/Else If/Else statements as required to do the following:
    Sort 3 numbers and output the smallest, middle and largest to the console.
	(Ask the user for the 3 numbers).
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
			
			// Get user's third number
			Console.WriteLine("\nPick your third number?!\n");
			string thirdNumber = Console.ReadLine();
			
			// Check if user's first input is a number
			try
			{
				// if so parse the first input to an integer
				int intFirstNumber = Int32.Parse(firstNumber);
				
				// if so parse the second input to an integer
				int intSecondNumber = Int32.Parse(secondNumber);
				
				// if so parse the third input to an integer
				int intThirdNumber = Int32.Parse(thirdNumber);
				
				// Compare numbers using Math (one line solution)
				//Console.WriteLine("The largest number is {0}, the middle number is {1}, the smallest number is {2}", 
									//Math.Max(intFirstNumber, Math.Max(intSecondNumber, intThirdNumber)), 
									//Math.Min(intFirstNumber, Math.Max(intSecondNumber, intThirdNumber)), 
									//Math.Min(intFirstNumber, Math.Min(intSecondNumber, intThirdNumber))
								 //);
				
				// Check if the first number is larger than the others
				if(intFirstNumber > intSecondNumber && intFirstNumber > intThirdNumber)
				{
					// Check if the second number is larger than the third number
					if(intSecondNumber > intThirdNumber)
					{
						Console.WriteLine($"The largest number is {intFirstNumber}, the middle number is {intSecondNumber} and the smallest number is {intThirdNumber}");
					}
					else
					{
						Console.WriteLine($"The largest number is {intFirstNumber}, the middle number is {intThirdNumber} and the smallest number is {intSecondNumber}");
					}
				}
				
				// Check if the second number is larger than the others
				else if(intSecondNumber > intFirstNumber && intSecondNumber > intThirdNumber)
				{
					// Check if the first number is larger than the third number
					if(intFirstNumber > intThirdNumber)
					{
						Console.WriteLine($"The largest number is {intSecondNumber}, the middle number is {intFirstNumber} and the smallest number is {intThirdNumber}");
					}
					else
					{
						Console.WriteLine($"The largest number is {intSecondNumber}, the middle number is {intThirdNumber} and the smallest number is {intFirstNumber}");
					}
				}
				
				// Check if the third number is larger than the others
				else if(intThirdNumber > intFirstNumber && intThirdNumber > intSecondNumber)
				{
					
					// Check if the first number is larger than the second number
					if(intFirstNumber > intSecondNumber)
					{
						Console.WriteLine($"The largest number is {intThirdNumber}, the middle number is {intFirstNumber} and the smallest number is {intSecondNumber}");
					}
					else
					{
						Console.WriteLine($"The largest number is {intThirdNumber}, the middle number is {intSecondNumber} and the smallest number is {intFirstNumber}");
					}
				}
				
				// Check if the numbers are equal
				else
				{
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