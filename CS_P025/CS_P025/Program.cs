using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P025
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse. \nHello, on new line. \n\tHello, on a tab.";
            //string filename = "C:\\Users\\Jesse";
            //// or filename = @"C:\Users\\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = quote.EndsWith(".");

            //int length = name.Length;
            //name = name.ToUpper();


            //Console.WriteLine(name);
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();
            sb.Append("New standard,\n");
            sb.Append(" King");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
