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
            // EX.4 In case of an Index number not existing is typed.
            string[] names = new string[5];
            names[0] = "John";
            names[1] = "Michael";
            names[2] = "Ken";
            names[3] = "Alex";
            names[4] = "David";

            Console.Write("Type an Index of names between 0 and 4: ");

            string input = Console.ReadLine();
            int index = 100;

            // Avoiding error by wrong input
            while (!int.TryParse(input.Trim(), out index) || index < 0 || index > names.GetUpperBound(0))
            {
                Console.Write("Please type an Index number between 0 and 4: ");
                input = Console.ReadLine();
            }

            Console.WriteLine(names[index] + "\n");
            Console.Read();


            //// Ex.2 Create a one-dimentional Array of integers. Ask user an index and display it.
            // Ex4 In case of an Index not existing is input.
            int[] nums = new int[] { 8, 25, 1982, 179, 70 };

            Console.Write("Type an Index of numbers between 0 and 4: ");
            string input2 = Console.ReadLine();
            int index2 = 100;

            // Avoiding error by wrong input
            while (!int.TryParse(input2.Trim(), out index2) || index2 < 0 || index2 > nums.GetUpperBound(0))
            {
                Console.Write("Please tpe an Index number between 0 and 4: ");
                input2 = Console.ReadLine();
            }


            Console.WriteLine(nums[index2] + "\n");
            Console.Read();

            //// Ex.3 Create a List of strings. Ask user index and display.
            // Ex.4 In case of an Index not existing is input.
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
            string input3 = Console.ReadLine();
            int index3 = 100; // Just out of range

            // Avoiding error by wrong input
            while (!int.TryParse(input3.Trim(), out index3) || index3 < 0 || index3 > list.Count - 1)
            {
                Console.Write("Please, type an Index numberbetween 0 and 7: ");
                input3 = Console.ReadLine();
            }
            
            Console.WriteLine(list[index3]);
            Console.Read();

        }
    }
}
