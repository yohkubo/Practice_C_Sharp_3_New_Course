using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P032_Exercise_Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> nums = new List<int>() { 5, 10, 15, 33, 57, 95, 100, 138, 144 };

                Console.WriteLine("Type a number to divide listed numbers.");
                int input = Convert.ToInt32(Console.ReadLine());

                foreach(int num in nums)
                {
                    Console.WriteLine((num / input));
                }
                Console.Read();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
