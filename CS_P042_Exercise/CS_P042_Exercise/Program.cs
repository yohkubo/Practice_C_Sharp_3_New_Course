using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P042_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int intResult;

            Console.WriteLine("Type 2 numbers. Second number is optional.\n1st No.: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Deal.Divide(num1, out intResult);

            int num2 = 0; //Optional number
            Console.WriteLine("2nd No.: ");

            // Running when second number inputed
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                Deal.Divide(num1, num2, out intResult);
                Console.WriteLine("You typed {0} and {1}. Then this divided {0} by 2 for {1} times.\nResult is: {2}",
                    num1, num2, intResult);
            }

            else
            {
            Console.WriteLine("You typed {0}, divided by 2\nResult: {1}",
                num1, intResult);
            }

            Console.WriteLine("Results are rounded down to one significant figures every time divided.");
            Console.ReadLine();
            
        }
    }
}
