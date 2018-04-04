using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P053_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            { FirstName = "Yohei", LastName = "Kubo", Id = 1 };
            Employee employee2 = new Employee()
            { FirstName = "Ken", LastName = "Saga", Id = 1 };

            if (employee1 == employee2)
                Console.WriteLine("{0} and {1} have same ID '{2}'.", 
                    employee1.LastName, employee2.LastName, employee1.Id);
            else Console.WriteLine("{0} is ID:{1}. {2} is ID:{3}.", 
                employee1.LastName, employee1.Id, employee2.LastName, employee2.Id);

            Console.ReadLine();
        }
    }
}
