using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P038_Exercise
{
    public class Calculation
    {
        public int tempF { get; set; }
        public decimal usD { get; set; }
        public string num { get; set; }
        public List<string> topics { get; set; }
        public List<string> scales { get; set; }

        public Calculation()
        {
            this.topics = new List<string>();
            topics.Add("Temperature");
            topics.Add("Money");
            topics.Add("Pizza");

            this.scales = new List<string>();
            scales.Add("degrees Celcius");
            scales.Add("japanese yen");
            scales.Add("whole pies of Pizza");

        }


        // Temperature converter from Fahrenheit(F) to Celsius(C)
        public int Status(int tempF)
        {
            int tempC = (tempF - 32) * 5 / 9; 

            return tempC;
        }

        // Calculation to exchange USD to JPY
        public int Status(decimal usD)
        {
            // USD1.00 = JPY116.90 @3/29/2018
            decimal exRate = 116.90m;
            int jpY = Convert.ToInt32(usD * exRate);

            return jpY;
        }
        
        // Calculate how many whole pizza you will need for today's party
        public int Status(string num)
        {
            // One whole pizza will be devided to 12 slices, and each 
            //person would eat 4 slices as assumption 
            decimal temp = (Convert.ToDecimal(num) * 4) / 12;

            int numPizza = Convert.ToInt32(Math.Ceiling(temp)); 

            return numPizza;
        }

    }
}
