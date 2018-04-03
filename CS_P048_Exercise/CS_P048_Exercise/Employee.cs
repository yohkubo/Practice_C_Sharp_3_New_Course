using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P048_Exercise
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee's Name: {0} {1}", FirstName, LastName);
        }
    }
}
