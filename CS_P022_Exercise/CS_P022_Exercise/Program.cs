using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P022_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? And how old are you?");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hi, " + name + "! You are " + age + " years old.");

            //Ex.1
            if (age > 20) Console.WriteLine("You definetely can drink alchol. Don't forget your ID when you go to bar.");
            //Ex.2
            else if (age == 20) Console.WriteLine("You are too young to drink alchol in the U.S.A., but other country might allow you to drink.");
            else if (age < 20) Console.WriteLine("You are too young to drink alchol in the U.S.A..");
            else Console.WriteLine("Something is wrong.");

            //Ex.3
            string apendix = (age == 35) ? "By the way, you're exact same age with Anne Hathaway." : "By the way, you can drink alchol from 20 in Japan.";
            Console.WriteLine(apendix);

            Console.Read();
        }
    }
}
