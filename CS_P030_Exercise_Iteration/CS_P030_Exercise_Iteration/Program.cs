using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P030_Exercise_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex.1 One-dimentional array, and asking uer to input some text and 
            //printing each element in array with user's input in separate line
            /*
            string[] greetings = { "Hello", "Ola", "Bonjour", "Chao",
                "Konnichiwa", "Ni-hao", "Annyeong haseyo", "Namaste" };

            Console.Write("Ex.1 What's your name? \nname: ");
            string name = Console.ReadLine();
            
           foreach(string greeting in greetings)
            {
                Console.WriteLine(greeting + ", " + name + "!!");
            }
            Console.Read();
            */

            //Ex.2 Create an infinite loop
            /*
            int[] nums = { 1, 4, 7, 9, 31, 42, 5, 4, 667, 55, 65, 90, 32 };
            Console.WriteLine("Ex.2 ");
            
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] < 30)
                {
                    Console.WriteLine(nums[i]);
                    i = 4; // This "4" does not mean anything. Just for making a infinite loop

                }
            }
            Console.Read();
            */

            //Ex.3 Fixing an infinite loop at Ex.2
            /*
            int[] nums = { 1, 4, 7, 9, 31, 42, 5, 4, 667, 55, 65, 90, 32 };
            Console.WriteLine("Ex.3 (Fixed Ex2)");
            

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 30)
                {
                    Console.WriteLine(nums[i]);
                 
                }
            }
            Console.Read();
            */

            // Ex.4 Create a loop with comparison using a "<" operator.
            /*
            List<int> nums4 = new List<int> { 1, 4, 7, 9, 31, 42, 5, 4, 667, 55, 65, 90, 32 };
            Console.WriteLine("Ex.4 Numbers under 31 in nums list:");
            for (int i=0; i < nums4.Count; i++)
            {
                if(nums4[i] < 31)
                {
                    Console.WriteLine(nums4[i]);
                }
            }
            Console.Read();
            */

            // Ex.5 Create a loop with comparison using a "<=" operator.
            /*
            int[] nums5 = { 1, 4, 7, 9, 31, 42, 5, 4, 667, 55, 65, 90, 32, 31 };
            Console.WriteLine("Ex.5 Numbers which is 31 or less than 31 in num list");
            for(int j = 0; j <= nums5.GetUpperBound(0); j++)
            {
                if(nums5[j] <= 31)
                {
                    Console.WriteLine(nums5[j]);
                }
            }
            Console.Read();
            */ //End Ex.4-5

            // Ex.6-7 Skipped


            // Ex.8 Create a list with unique strings, ask user to input one of them and 
            //display the index of the string in the array
            // Ex.9 Add code to tell the user that the number input not existing.
            // Ex.10 Add code to stop executing when a match has been found.

            /*
            List<string> greetings = new List<string>() { "Hello", "Ola", "Bonjour", "Chao", "Konnichiwa", "Nihao", "Annyeong haseyo", "Namaste" };

            Console.WriteLine("Ex.8-10 Select and type one from following:\n" +
                "'Hello', 'Ola', 'Bonjour', 'Chao', 'Konnichiwa', 'Nihao', 'Annyeong haseyo', 'Namaste'.");
            bool search = false;

            while(search == false) // Iterating as long as a match isn't found
            {
                string greeting = Console.ReadLine();

                foreach(string select in greetings)
                {
                    if (select == greeting)
                    {
                        Console.WriteLine("Index of greeting you selected is: " + greetings.IndexOf(select));
                        search = true;
                        break;  // For Ex.10
                     }
                    
                }
               if (search == false) Console.WriteLine("Select a greeting from above list.");  
            }
            Console.Read();
            */ // End Ex.8-10


            // Ex.11 Create a list including identical strings, and ask user to 
            //select from the strings and display indices of the strings in the list.
            // Ex.12 Add code to tell user when input has no match in the list.

            /* 
            List<string> greetings = new List<string>()
            {"Hello", "Ola", "Bonjour", "Chao", "Konnichiwa", "Nihao", "Annyeong haseyo", "Namaste", "Ola", "Namaste", "Hello", "Konnichiwa"};

            Console.Write("Ex.8-10 Select and type one from following:\n" +
                "'Hello', 'Ola', 'Bonjour', 'Chao', 'Konnichiwa', 'Nihao', 'Annyeong haseyo', 'Namaste'.\n" +
                "Please input: ");
            List<int> selection = new List<int>();
            bool search = false; 

            while(search == false)
            {
                string select = Console.ReadLine();
            
                for (int k = 0; k < greetings.Count; k++)
                {
                    if(greetings[k] == select)
                    {
                        selection.Add(k);
                        search = true;
                    }
                }
                if (search == false) Console.WriteLine("Select a greeting from above list");
                
            }

            Console.Write("Indices of the greeting you selected are: ");

            //string result="";
            for (int k = 0; k < selection.Count(); k++)
            {
                Console.Write(selection[k]);
                if(k != selection.Count() - 1) Console.Write(", "); // No need "," for last one.
            }
            Console.Read();
            */ // End Ex.11-12


            // Ex.13 Create a list with identificial strings, and evaluate and 
            //display a message if the item already showed.

            List<string> greetings = new List<string>()
            {"Hello", "Ola", "Bonjour", "Chao", "Hello", "Konnichiwa", "Ola", "Nihao", "Annyeong haseyo", "Namaste", "Ola", "Namaste", "Hello", "Konnichiwa"};
            
            Console.WriteLine("Ex.13 Cecking my greeting list if it has duplicates: ");

            List<string> check = new List<string>();
            
            foreach (string greeting in greetings)
            {
                Console.Write(greeting);
                //Checking if the greeting displayed before
                foreach (string checking in check)
                {
                    if (checking == greeting)
                    {
                        Console.Write(" (duplicate)");
                        break;
                    }
                }
                Console.Write("\n");
                check.Add(greeting);
            }
            Console.Read();
        }
    }
}
