using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNum, minNum, maxNum, numOfGuesses, userInput;
            minNum = 1;
            maxNum = 20;

            // Banner that displays only once at start of the program.
            Console.WriteLine("#####################################################");
            Console.WriteLine("####                                             ####");
            Console.WriteLine("####        RANDOM NUMBER GUESSING GAME          ####");
            Console.WriteLine("####                                             ####");
            Console.WriteLine("#####################################################");
            Console.WriteLine(); // Adding another new line.

            /*
            * Generates new number within range and asks the user to guess the number.
            */

            // Creates RNG and sets variables for start of the game.
            Random rng = new Random();
            randomNum = rng.Next(minNum, maxNum);
            numOfGuesses = 0;

            //Console.WriteLine(randomNum); Uncomment if you want to know random number (for debugging).
            Console.Write("Guess a number between {0} and {1}: ", minNum, maxNum);

            // Priming the loop
            userInput = Convert.ToInt16(Console.ReadLine());
            numOfGuesses++;
            while (userInput != randomNum)
            {
                if (userInput > randomNum)
                {
                    Console.Write("Sorry, too HIGH! Please try again: ");
                }
                else if (userInput < randomNum)
                {
                    Console.Write("Too LOW! Try again: ");
                }

                numOfGuesses++; // Starts from zero and increments.
                userInput = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Congrats! You guessed correctly.");

            // Displays the results of the game if you win and the number of guesses.
            Console.WriteLine("\n\n"); // Just adding padding to more seperate results from other content.
            Console.WriteLine("#####################################################");
            Console.WriteLine("####                                             ####");
            Console.WriteLine("####                GAME RESULTS                 ####");
            Console.WriteLine("####                                             ####");
            Console.WriteLine("####  Number of Guesses: {0}                       ####", numOfGuesses);
            Console.WriteLine("####                                             ####");
            Console.WriteLine("#####################################################");

            Console.Read(); // for debugging only
        }
    }
}
