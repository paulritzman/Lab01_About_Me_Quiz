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
            Console.WriteLine("Lets play a guessing game!\n");

            // Asks the user to guess my age - AskAgeQ returns -1 if no valid guess input.
            int ageGuess = AskAgeQ();
            CheckAgeAnswer(ageGuess);

            // Asks the user to guess where I was born.
            string cityGuess = AskBirthCityQ();
            CheckBirthCityAnswer(cityGuess);

            // Asks the user to guess if I was ever a dancer.
            bool dancerGuess = AskDancerQ();
            CheckDancerAnswer(dancerGuess);

            // Asks the user to guess which country I will be traveling to when going overseas for the first time.
            string vacationGuess = AskOverseasVacationQ();
            CheckOverseasVacationAnswer(vacationGuess);

            // Asks the user to guess which Code 401 course I chose to take at Code Fellows
            string code401Guess = AskCode401Q();
            CheckCode401Answer(code401Guess);
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
                Console.WriteLine($"\nYou did not input a valid, positive number: {e.Message}\n");
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
            
            // Converts user input to lower case, to simplify the comparison with correctCity in CheckBirthCityAnswer().
            string guess = Console.ReadLine().ToLower();
            return guess;
        }

        static void CheckBirthCityAnswer(string guessedCity)
        {
            // Preserving correct capitalization of birthCity, for use in output text
            string birthCity = "Everett";

            if (guessedCity == birthCity.ToLower())
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

        static string AskOverseasVacationQ()
        {
            Console.Write("What country do I have designated as the destination for my first overseas vacation? ");

            // Converts user input to lower case, to simplify the comparison with destinationCountry in CheckOverseasVacationAnswer().
            string guess = Console.ReadLine().ToLower();
            return guess;
        }

        static void CheckOverseasVacationAnswer(string guessedDestination)
        {
            // Preserving correct capitalization of destinationCountry, for use in output text
            string destinationCountry = "South Korea";

            if (guessedDestination == destinationCountry.ToLower())
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine($"Incorrect, I will be traveling to {destinationCountry} on August 17, 2018.\n");
            }
        }

        static string AskCode401Q()
        {
            Console.Write("Which 401 course did I choose to pursue at Code Fellows? ");

            // Converts user input to lower case, to simplify the comparison with acceptable answers in CheckCode401Answer().
            string guess = Console.ReadLine().ToLower();
            return guess;
        }

        static void CheckCode401Answer(string guessedCourse)
        {
            // Defines multiple acceptable answers
            // Preserving correct capitalization for use in output text
            string code401Course = "ASP.NET Core", code401Shortened = ".NET", code401Language = "C#";

            if (guessedCourse == code401Course.ToLower() || guessedCourse == code401Shortened.ToLower() || guessedCourse == code401Language.ToLower())
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine($"Incorrect, I chose to take the {code401Course} course.");
                Console.WriteLine($"Other accepted answers: {code401Shortened} and {code401Language}.\n");
            }
        }
    }
}