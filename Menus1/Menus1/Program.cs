using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Menus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Program menu and other methods execution
             */

            bool doMenu = true;

            while(doMenu)
            {

                Console.WriteLine("\nPlease select an option number from the list and press enter:");
                Console.WriteLine("Option 1 (1) - Guess A Number Game");
                Console.WriteLine("Option 2 (2)");
                Console.WriteLine("Option 3 (3)");
                Console.WriteLine("Option 4 (4)");
                Console.WriteLine("Exit (e)\n");

                Console.Write("\nOption: ");
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    GuessANumber();
                }
                else if (selection == "2")
                {
                    // Ask a user for a number and tell if it is an odd or even number.
                    OddOrEven();
                }
                else if (selection == "3")
                {
                    // Hangman game. Ask user to guess the letters of 5 letter word.
                    // Give them 15 attempts and present the correctly guessed letters in the 
                    // correct order.

                    HangMan();
                }
                else if (selection == "4")
                {
                    // If you're brave enough!!! 
                }
                else if (selection.ToLower() == "e")
                {
                    doMenu = false;
                }
                else
                {

                }

            }

        }
        
        static void GuessANumber()
        {
            /*
                Collect an input from the user and compare the number collected against
                a pseudo random number
             */

            int num = 0;
            string userInput = "";
            int userNum = 0;
            bool doGuess = true;
            int attempts = 0;
            bool isCorrect = false;

            Console.WriteLine("\nGuess A Number Game");
            Random random = new Random();
            num = random.Next(1, 11);

            while(doGuess)
            { 
                attempts++;

                Console.WriteLine($"\nYou have {6 - attempts} remaning\n");

                Console.WriteLine("Guess A Number between 1 and 10!!!\n");
                userInput = Console.ReadLine();


                if (int.TryParse(userInput, out userNum))
                {

                    Console.WriteLine($"\nChecking random number {num} against Guessed number.\n");

                    if (userNum == num)
                    {
                        Console.WriteLine($"Congratulations, {userNum} matches {num}.\n");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, please try again!\n");
                    }

                }
                else
                {
                    Console.WriteLine("\nInvalid input, try again!\n");
                }

                if(isCorrect || attempts > 6)
                {
                    doGuess = false;
                }

            }

        }

        static void OddOrEven()
        {
            /*
               Collect user's input and Check if the given number is Odd or Even
            */

            while(true)
            {

                // Get user's number
                GetUserNumber:
                    Console.Write("\nPick your number: ");
                    string userInput = Console.ReadLine();

                // Check if user input is a number
                try
                {

                    // Parse user input to int
                    int userNum = Int32.Parse(userInput);

                    // Check if number is odd
                    if (userNum % 2 == 0)
                    {
                        Console.WriteLine($"\nYour number ({userNum}) is even.\n");
                    }
                    // Check if number is odd
                    else
                    {
                        Console.WriteLine($"\nYour number ({userNum}) is odd.\n");
                    }

                    // Check if user want to keep playing
                    bool keepPlaying = PlayAgain();

                    // If true go to the game beginning
                    if(keepPlaying)
                    {
                        goto GetUserNumber;
                    }

                    // If false stop current game
                    else
                    {
                        break;
                    }

                }

                // Throw an error if the user input is not a number and send to the game beginning
                catch
                {

                    Console.WriteLine($"\nOi! dumb, '{userInput}' is not a number!\n");
                    goto GetUserNumber;

                }

            }

        }

        static void HangMan()
        {
            /*
                Hangman game
             */

            string[] words = { "rugby", "skiing", "football" };
            string word = null;
            int? numberOfAttemps = null;

            string difficulty = ChooseDifficulty();
            if(difficulty == "BABY")
            {
                word = words[0];
                numberOfAttemps = 15;
            }
            else if(difficulty == "ROOKIE")
            {
                word = words[1];
                numberOfAttemps = 10;
            }
            else if (difficulty == "APOCALYPSE")
            {
                word = words[2];
                numberOfAttemps = word.Length;
            }

        GameBeginning:
                Console.WriteLine("\nHey! the Hangman depends on you to survive, Will you be able to save him?! :|\n");
            
            Console.WriteLine($"The word has {word.Length} letters and you have {numberOfAttemps} attemps to find out the word and save the Hangman. :/\n");

            int charIndex = -1;
            char[] choosenLetters = new char[word.Length];
            string fullWord = "";
            int attempts = 0;


            for (int i = 0; i < choosenLetters.Length; i++)
            {
                choosenLetters.SetValue(value: '\0', index: i);
            }

            while (attempts < numberOfAttemps)
            {
                
                attempts++;
                Console.WriteLine($"\nIt's your attempt number {attempts}, you have more {numberOfAttemps - attempts} attempts to save the Hangman! :(\n");

                Console.WriteLine("Guess the word: ");
                for (int letter = 0; letter < word.Length; letter++)
                {
                    if (charIndex != -1)
                    {
                        if (letter == charIndex && choosenLetters.Length != -1)
                        {
                            for (int charInd = 0; charInd < choosenLetters.Length; charInd++)
                            {
                                char elem = choosenLetters[charInd];

                                if (elem == '\0')
                                {
                                    Thread.Sleep(500);
                                    Console.Write(" _ ");
                                }
                                else
                                {
                                    char choosenChar = choosenLetters[charInd];
                                    Thread.Sleep(500);
                                    Console.Write($" {Char.ToUpper(choosenChar)} ");
                                }

                            }
                        }
                        
                    }
                    else
                    {
                        Thread.Sleep(100);
                        Console.Write($" _ ");
                    }

                }

                if (fullWord == word)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("YOU ARE THE HERO, yeah you saved the Hangman! :D");

                    bool keepPlaying = PlayAgain();

                    if(keepPlaying)
                    {
                        goto GameBeginning;
                    }
                    else
                    {
                        break;
                    }

                }


                Console.WriteLine("\n");
                Console.WriteLine("\nWhat's your guess?");
                char userInput = Console.ReadKey().KeyChar;
                char lowerChar = Char.ToLower(userInput);

                if (word.IndexOf(lowerChar) != -1)
                {

                    int ix = 0;
                    while ((ix = word.IndexOf(lowerChar, ix)) != -1)
                    {
                        // Print out the index.
                        choosenLetters.SetValue(value: lowerChar, index: ix);
                        charIndex = ix;
                        ix++;
                    }

                    fullWord = new string(choosenLetters);

                }
                else
                {
                    Console.WriteLine("\nBrrrrrrrrrrrr wrong answer!!!\n");
                }

            }

            if(attempts == 15)
            {
                Console.WriteLine("Oooh no! You had just one task and you failed, the Hangman is dead! x|");
            }

        }

        static bool PlayAgain()
        {
            /*
                Ask if user want to repeat the game
             */

            keepPlayingQuestion:
                Console.Write("Would you like to play again? (y/n)");
                string userAnwser = Console.ReadLine();

            if(userAnwser.ToLower() == "y")
            {
                return true;
            }
            else if(userAnwser.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine($"\nOi! dumb, '{userAnwser}' is not 'y' or 'n'!\n");
                goto keepPlayingQuestion;
            }

        }

        static string ChooseDifficulty()
        {
            /*
                Allow users to choose game difficulty
             */

            string[] difficulties = {"baby", "rookie", "apocalypse"};

            Beginning:
                Console.WriteLine("\n Choose your game difficulty:\n");

            for(int difficulty = 0; difficulty < difficulties.Length; difficulty++)
            {
                Console.WriteLine($"Option {difficulty + 1} - Type '{difficulties[difficulty]}' on console");
            }

            string userOption = Console.ReadLine();

            if(difficulties.Contains(userOption.ToLower()))
            {
                Console.WriteLine($"\nYou choose {userOption.ToUpper()}, face your consequences!\n");
                return userOption.ToUpper();
            }
            else
            {
                Console.WriteLine("\nOi! mate, choose only the pre defined options\n");
                goto Beginning;
            }
        }

    }
}
