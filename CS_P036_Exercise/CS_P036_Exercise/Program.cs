using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P036_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangular volume calculation.\nType Height, Width and Length with inch.");
            Calculation calculation = new Calculation();
            calculation.Height = Convert.ToInt32(Console.ReadLine());
            calculation.Width = Convert.ToInt32(Console.ReadLine());
            calculation.Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The volume of this rectangular is: " + calculation.Volume() + "cubic inches");
            Console.Read();
        }
    }
}
