using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P023_Exercise
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // Ex.1
            /*
            Random random = new Random();
            int number = random.Next(13);

            Console.Write("Click to generate a random number.");
            Console.Read();
            Console.WriteLine(number);
            Console.Read();

            while (number != 7)
            {
                Console.Write("Keep clicking until 7 comes out.");
                Console.ReadLine();
                Console.WriteLine(number = random.Next(13));
            }

            Console.WriteLine("You got 7!! Congrats!!!");
            Console.Read();
            Console.Read();
            */

            //Ex.2
            Random random = new Random();

            Console.WriteLine("Click Enter button to get a number from a random number generater.");
            int number = random.Next(13);
            bool num7 = number == 7;


            do
            {
                switch (number)
                {
                    case 6:
                        Console.Write("Wooo, " + number.ToString() + ", so close! Keep Clicking!");
                        number = random.Next(13);
                        Console.ReadLine();
                        break;

                    case 8:
                        Console.Write("Ahhh, " + number.ToString() + ", so close! Keep Clicking!");
                        number = random.Next(13);
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("You got 7! That's what you wanted!! Congrats!!");
                        num7 = true;
                        break;

                    default:
                        Console.Write(number.ToString() + ", too far. Think, and try again.");
                        number = random.Next(13);
                        Console.ReadLine();
                        break;
                }
            } while (!num7);

                Console.Read();
            
        }
    }
}
