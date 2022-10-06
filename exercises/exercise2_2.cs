/*
    Use If/Else If/Else statements as required to do the following:
    a.	Ask the user what age they are.
	b.	Ask them if they have id. (Y/N).
	c.	A user who is over 18 and has id can be admitted
		to the club, otherwise they cannot. Output a 
		suitable message for each scenario.
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
				Console.WriteLine("\nPick a number?!\n");
			
			// Get user's number
			string number = Console.ReadLine();
			
			// Check if user's input is a number
			try
			{
				// if so parse the input to an integer
				int intNumber = Int32.Parse(number);
				
				if(intNumber < 5 || intNumber > 50)
				{
					// if the number is less than 5 or greater than 50 then print this message
					Console.WriteLine("\nYou choose a number less than 5 or greater than 50, very nice your number!\n");
				}
				else 
				{
					// if the number is not less than 5 or greater than 50 then print this message
					Console.WriteLine("\nYou choose a number that is not less than 5 or greater than 50, very nice your number as well!\n");
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