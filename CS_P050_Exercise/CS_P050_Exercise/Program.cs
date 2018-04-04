using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P050_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            IQuittable quittable = new Employee() { FirstName = "Yohei", LastName = "Kubo" };
            quittable.Quit();
            Console.ReadLine();

            //Employee employee = new Employee() { FirstName = "Ken", LastName = "Saga" };
            //employee.Quit();
            //Console.ReadLine();

        }
    }
}
