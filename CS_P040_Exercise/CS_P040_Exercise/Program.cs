using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P040_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Deal deal = new Deal();

            Console.Write("Type 2 numbers.\nNumber 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            deal.Power(num1, num2);
            Console.ReadLine();
        }
    }
}
