﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P048_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee() { FirstName = "Sample", LastName = "Student" };

            person.SayName();
            Console.Read();
        }
    }
}
