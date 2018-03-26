using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P023
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isGuess = false;

            while(!isGuess)
            {
                Console.Write("Guess a number?: ");
                number = Convert.ToInt32(Console.ReadLine());
            

                switch (number)
                {
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        break;
                    case 50:
                        Console.WriteLine("You geussed 50. Try again.");
                        break;
                    case 100:
                        Console.WriteLine("You guessed 100. That is correct!!");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("Your guess is not even close. So wrong!");
                        break;

                }
            }
            Console.Read();

        }
    }
}
