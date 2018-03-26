using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P020_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1 //
            //Takes an input
            Console.Write("PART 1: Input a number:");
            //int myNumber = int.Parse(Console.ReadLine());
            int myNumber = Convert.ToInt32(Console.ReadLine());

            //Ex.1
            Console.WriteLine("Ex.1 Your number multiplied with 50 is: " + myNumber * 50);
            
            //Ex.2
            Console.WriteLine("Ex.2 Your number added 25 is: " + (myNumber + 25));

            //Ex.3
            double myDivided = Convert.ToDouble(myNumber);
            Console.WriteLine("Ex.3 Your number divided by 12.5 is: " + myDivided / 12.5);

            //Ex.4
            bool greater = myNumber > 50;
            
            Console.WriteLine("Ex.4 Your number is greater than 50?: " + greater);

            //Ex.5
            Console.WriteLine("Ex.5 Remainder, when divied your number by 7, is: " + myNumber % 7);

            Console.Write("Click enter");
            Console.ReadLine();

            // PART 2 //
            Console.WriteLine("PART 2:");
            //Ex.1
            bool comparison = 3 > 2 && 5 > 4;
            Console.WriteLine("Ex.1 3>2 and 5>4: " + comparison);

            //Ex.2
            comparison = 3 > 2 || 5 > 4;
            Console.WriteLine("Ex.2 3>2 or 5>4: " + comparison);

            //Ex.3
            comparison = (2 + 2) == 4;
            Console.WriteLine("2+2 does not equal 4: " + comparison);

            Console.Read();
            
        }
    }
}
