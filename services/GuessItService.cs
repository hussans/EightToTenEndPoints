using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTenEndPoints.services
{
    public class GuessItService
    {
        private int targetNumber = 0;
        public string HandleGame(string mode, string guess)
        {
            Random random = new Random();

            if(targetNumber == 0)
            {
                mode = mode.ToLower();

                switch(mode)
                {
                    case "easy":
                        targetNumber = random.Next(1, 11);
                        break;
                    case "medium":
                        targetNumber = random.Next(1, 51);
                        break;
                    case "hard":
                        targetNumber = random.Next(1, 101);
                        break;
                    default:
                        return "Invalid mode. Please choose easy, medium, or hard.";
                }
            }

            int guessedNumber;
            bool isValid = int.TryParse(guess, out guessedNumber);
            if(!isValid)
            {
                return "Invalid input. Please enter a valid number.";
            }

            if(guessedNumber < targetNumber)
            {
                return "Your guess is too low.";
            }
            else if(guessedNumber > targetNumber)
            {
                return "Your guess is too high.";
            }
            else
            {
                string result = "Congratulations! You guessed the correct number!";
                targetNumber = 0;
                return result;
            }
        }
    }
}