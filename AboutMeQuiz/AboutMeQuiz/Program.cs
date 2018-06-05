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
            int ageGuess = AskAgeQ();
            CheckAgeAnswer(ageGuess);

            // Asks the user to guess where I was born.
            string cityGuess = AskBirthCityQ();
            CheckBirthCityAnswer(cityGuess);

            // Asks the user to guess if I was ever a dancer.
            bool dancerGuess = AskDancerQ();
            CheckDancerAnswer(dancerGuess);

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
                Console.WriteLine($"\nYou did not input a valid, positive number: {e}\n");
            }

            // return -1 as CheckAgeAnswer is called next, and age can never be a negative - so will always be false.
            return -1;
        }

        static void CheckAgeAnswer(int guessedAge)
        {
            int currentAge = 25;

            if (guessedAge == currentAge)
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine($"Sorry, that was incorrect. I am actually {currentAge}.\n");
            }
        }

        static string AskBirthCityQ()
        {
            Console.Write("Which city was I born in? ");
            
            // Converts user input to lower case, in order to simplify the comparison with correctCity in CheckBirthCityAnswer().
            string guess = Console.ReadLine().ToLower();
            return guess;
        }

        static void CheckBirthCityAnswer(string guessedCity)
        {
            string birthCity = "everett";

            if (guessedCity == birthCity)
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine($"Incorrect, I was actually born in {birthCity}.\n");
            }
        }

        static bool AskDancerQ()
        {
            Console.Write("Was I ever a dancer (type 1 for yes, or 2 for no)? ");

            string guess = Console.ReadLine();

            if (guess == "1")
            {
                return true;
            }
            else if (guess != "2")
            {
                Console.WriteLine("You did not enter \"1\" or \"2\".\n");
            }

            // Returns false if anything other than "1" is input.
            return false;
        }

        static void CheckDancerAnswer(bool guessedDancer)
        {
            bool wasDancer = true;

            if (guessedDancer == wasDancer)
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect, I was a Ukrainian dancer for 3 years.\n");
            }
        }
    }
}
