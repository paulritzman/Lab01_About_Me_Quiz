using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user to guess my age - AskAgeQ returns -1 if no valid guess input.
            int userGuess = AskAgeQ();
            CheckAgeAnswer(userGuess);


            Console.ReadLine();
        }

        static int AskAgeQ()
        {
            Console.Write("How old am I? ");
            
            // Try/Catch block to validate that user input is a positive number.
            // Returning int instead of uint, as the input has already been validated as positive.
            try
            {
                uint guess = uint.Parse(Console.ReadLine());
                return (int)guess;
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nYou did not input a valid number: {e}\n");
            }

            // return -1 as CheckAgeAnswer is called next, and age can never be a negative - so will always be false.
            return -1;
        }

        static void CheckAgeAnswer(int guessedAge)
        {
            int correctAge = 25;

            if (guessedAge == correctAge)
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine($"Sorry, that was incorrect. I am actually {correctAge}.\n");
            }
        }
    }
}
