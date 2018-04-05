using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P055_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Excercise on P.55 
            // Made Employee class take a generic type parameter(Ex.1)
            // Create a property of a generic list type called "Things"(Ex.2) 

            // For New C#, Exercise no.3 on P.55
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "key", "car", "laptop"};
            // For Exercise no.4
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 178, 71, 9 };

            foreach(string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            //Employee employee1 = new Employee()
            //{ FirstName = "Yohei", LastName = "Kubo", Id = 1 };
            //Employee employee2 = new Employee()
            //{ FirstName = "Ken", LastName = "Saga", Id = 1 };

            //if (employee1 == employee2)
            //    Console.WriteLine("{0} and {1} have same ID '{2}'.",
            //        employee1.LastName, employee2.LastName, employee1.Id);
            //else Console.WriteLine("{0} is ID:{1}. {2} is ID:{3}.",
            //    employee1.LastName, employee1.Id, employee2.LastName, employee2.Id);

            //Console.ReadLine();
        }
    }
}
