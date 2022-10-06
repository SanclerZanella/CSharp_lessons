/*
    Use If/Else If/Else statements as required to do the following:
    a.	Ask the user for a number.
	b.	Your program should only output 1 of 2 messages:
			i.	Output a suitable message for a number that is
				either less than 5 or greater than 50.
			ii.	Otherwise output a suitable message for a number
				that is not either less than 5 or greater than 50.
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
				Console.WriteLine("\nHow old are you?\n");
			
			// Get user's age
			string age = Console.ReadLine();
			
			// ProgramMiddle label
			ProgramMiddle:
				Console.WriteLine("\nDo you have an ID? (yes/no)\n");
			
			// Ask if user has id or not
			string userId = Console.ReadLine();
			
			// Check if age is number
			try
			{
				// Check if id answer is 'yes' or 'no'
				if(userId.ToLower() == "yes" || userId.ToLower() == "no")
				{
					// if id answer is 'yes' or 'no', then parse age to integer
					int intAge = Int32.Parse(age);
				
					if(intAge >= 18 && userId == "yes")
					{
						// If user's age is above or equal 18 and he has an ID
						Console.WriteLine("\nWelcome to the club!!!\n");
					}
					else
					{
						// any othe condition
						Console.WriteLine("\nGET OUT!!!\n");
					}
				}
				else
				{
					// Ask the user to answer just 'yes' or 'no' in the ID input and go to the ProgramMiddle label
					Console.WriteLine("\nPlease just answer 'yes' or 'no'\n");
					goto ProgramMiddle;
				}
					
				
			}
			catch(Exception e)
			{
				// Ask the user to provider a number and go to the start of the code
				Console.WriteLine($"\n{e.Message} - Please inform a NUMBER as your age\n");
				goto ProgramStart;
			}
			
			ProgramEnd:
			// Ask if the user wants to continue executing the program
				Console.Write("\nWould you like to continue? (y/n)\n");
			
			string ans = Console.ReadLine();

			// Check if answer is 'y' or 'n'
			if(ans.ToLower() == "y")
			{
				// Go to the start of the code
				continue;
			}
			else if(ans.ToLower() == "n")
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