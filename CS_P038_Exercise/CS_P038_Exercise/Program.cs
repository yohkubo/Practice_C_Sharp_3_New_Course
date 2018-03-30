using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P038_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            Console.WriteLine("Select a topic from below and type a number: " +
                "\n1: Temperature, 2: Money, 3: Today's party.");

            try
            {
                int topic = Convert.ToInt16(Console.ReadLine());
                bool vali = false;
                int result = 0;
            

                while (!vali)
                {
                    switch (topic)
                    {
                        case 1:
                            Console.WriteLine("What's the temperature in Fahrenheit? This is converting into Celcius. Do not input fraction.");
                            // passing a integer value 
                            result = calculation.Status(Convert.ToInt16(Console.ReadLine()));
                            vali = true;
                            break;

                        case 2:
                            Console.WriteLine("How many dollers in your wallet? This is converting it into japanese yen.");
                            //passing a Decimal value
                            result = calculation.Status(Convert.ToDecimal(Console.ReadLine()));
                            vali = true;
                            break;

                        case 3:
                            Console.WriteLine("You are having a party today. How many friends coming? \nThis is calculating how many whole pies of Pizza you will need." +
                                "\nAssumption:Each whole pizza is devided to 12 slices. Each person is supposed to eat 3 slices of pizza.");
                            // passing a string value
                            result = calculation.Status(Console.ReadLine());
                            vali = true;
                            break;

                        default:
                            Console.WriteLine("Something is wrong. Type again.\n Topic number?");
                            topic = Convert.ToInt16(Console.ReadLine());
                            break;
                    }
                } // End while

            Console.WriteLine("You chose " + calculation.topics[topic - 1] 
                + "\nThe answer is :" + result.ToString("N0") + " " + calculation.scales[topic - 1] );
            Console.ReadLine();

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
