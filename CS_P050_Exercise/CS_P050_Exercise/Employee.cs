using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P050_Exercise
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee's Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1}, You have quit the job...", FirstName, LastName); 
            
        }
    }
}
