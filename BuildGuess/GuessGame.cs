using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildGuess
{
    internal class GuessGame
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while (guess != secretWord && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuess= true;
                }
               
            }
            if(outOfGuess)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
           
            Console.ReadLine();
        }
    }
}
