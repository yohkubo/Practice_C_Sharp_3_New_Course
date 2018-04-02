using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P044_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee() {FirstName = "Sample", LastName = "Student", Id = 01 };

            sample.SayName();

            Console.WriteLine(sample.Id);
            Console.ReadLine();
        }
    }
}
