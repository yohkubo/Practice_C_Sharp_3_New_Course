﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("what is your name?");
            //string yourname = Console.ReadLine();
            //Console.WriteLine("your name is:" + yourname);
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //int favoriteNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.Read();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Jesse";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(questionMark);
            Console.Read();


        }
    }
}
