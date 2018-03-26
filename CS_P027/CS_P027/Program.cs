using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P027
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Ver.1
            //    int[] numArray = new int[5];
            //    numArray[0] = 5;
            //    numArray[1] = 2;
            //    numArray[2] = 10;
            //    numArray[3] = 200;
            //    numArray[4] = 1000;

            //    // Ver.2
            //    int[] numArray1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    //Ver.3
            //    int[] numArray2 = { 100, 200, 300, 400, 500 }; 

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Add(5);
            intList.Remove(10);
            
            Console.WriteLine(intList[1]);
            Console.Read();



        }
    }
}
