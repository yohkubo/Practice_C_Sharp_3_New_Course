using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P031_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Type a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type an another number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equal " + numberThree);
            Console.Read();
            }

            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.Read();
            //}

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
            finally
            {
                Console.WriteLine("Next...");
                Console.Read();
            }


        }
    }
}
