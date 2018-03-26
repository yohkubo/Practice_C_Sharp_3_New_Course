using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P026_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex.1 Concatenate three strings
            string name = "Yohei";
            string age = "35";
            string interest = "computer programming";

            Console.WriteLine("My name is " + name + ", " + age + " years old. I', interested in " + interest + ".");
            Console.ReadLine();

            //Ex.2 Convert a string to uppercase
            Console.WriteLine(name.ToUpper());
            Console.ReadLine();

            //Ex.3 Create a Stringbuilder and build a paragraph of text
            StringBuilder sb = new StringBuilder();

            sb.Append("I am learning C# at The Techacademy in Portland. ");
            sb.Append("It's been almost for 6 months. ");
            sb.Append("Learning programming is so exciting and I really enjoy it. ");
            sb.Append("Hopefully, I will get a job after graduating this course. ");
            sb.Append("I wish I could do it in the united stetes.");

            Console.WriteLine(sb);
            Console.Read();



        }
    }
}
