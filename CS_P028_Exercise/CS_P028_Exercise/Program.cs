using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P028_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex.1 Create a one-dimentional Array of strings. Ask user an index and display it.
            string[] names = new string[5];
            names[0] = "John";
            names[1] = "Michael";
            names[2] = "Ken";
            names[3] = "Alex";
            names[4] = "David";

            Console.Write("Type an Index of names between 0 and 4: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(names[index] + "\n");
            //Console.Read();

            // Ex.2 Create a one-dimentional Array of integers. Ask user an index and display it.
            int[] nums = new int[] { 8, 25, 1982, 179, 70 };

            Console.Write("Type an Index of numbers between 0 and 4: ");
            int index2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nums[index2] + "\n");
            //Console.Read();

            // Ex.3 Create a List of strings. Ask user index and display.
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("Ola");
            list.Add("Bonjour");
            list.Add("Chao");
            list.Add("Konnichiwa");
            list.Add("Ni-hao");
            list.Add("Annyeong haseyo");
            list.Add("Namaste");

            Console.Write("Type an Index of different kinds of Hello around the world between 0 and 7: ");
            int index3 = Convert.ToInt32(Console.Read());
            Console.WriteLine(list[index3]);
            Console.Read();

        }
    }
}
