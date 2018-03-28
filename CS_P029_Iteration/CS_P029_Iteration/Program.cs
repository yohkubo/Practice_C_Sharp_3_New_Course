using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P029_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for(int i=0; i < testScores.Length; i++)
            //{
            //    Console.WriteLine("Test Scores \nStudent ID [" + i +  "]: " + testScores[i]);
            //}
            //Console.Read();


            //string[] names = { "Jesse", "Erik", "Daniel", "Adam", "Erik", "Ken" };

            //for(int j = 0; j < names.Length; j++)
            //{
            //    if(names[j] == "Erik")
            //    {
            //        Console.WriteLine(j + ":" + names[j]);
            //    }
            //}
            //Console.Read();


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach(int score in testScores)
            //{
            //    if(score > 80)
            //    {
            //    Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.Read();


            //List<string> names = new List<string>();
            //names.Add("Jesse");
            //names.Add("Erik");
            //names.Add("Adam");
            //names.Add("Daniel");
            //names.Add("Ken");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.Read();


            List<int> testScores = new List<int>() { 98, 99, 12, 73, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach(int score in testScores)
            {
                if (score > 80)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.Read();





        }
    }
}
