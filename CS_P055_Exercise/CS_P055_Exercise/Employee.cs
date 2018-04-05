using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P055_Exercise
{
    class Employee<T> : Person
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee's Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1}, You have quit the job...", FirstName, LastName);
        }

        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    return employee1.Id == employee2.Id;
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return !ReferenceEquals(employee1.Id, employee2.Id);
        //}

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

    }
}
