using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P034_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are some good deal to buy. Type a number of property which you want to know detail of." +
                "\n1:Laptop, 2:Refrigerator, 3:Car.");
            string num = Console.ReadLine(); // Use number as string data to avoid error.
            string deal = "";

            switch (num)
            {
                case "1": 
                    deal = "Laptop";
                    Console.WriteLine("Class Name:" + deal); //or Apple().GetType()
                    Console.WriteLine("Detail is folloing - \n Maker: " + Apple().Make
                        + "\n Model: " + Apple().Model + "\n Year: " + Apple().Year
                        + "\n Color: " + Apple().Color + "\n Price: " + Apple().Price);

                    break;

                case "2":
                    deal = "Refrigerator";
                    Console.WriteLine("Class Name:" + deal);
                    Console.WriteLine("Detail is folloing - \n Maker: " + Summit().Make
                        + "\n Model: " + Summit().Model + "\n Year: " + Summit().Year
                        + "\n Color: " + Summit().Color + "\n Price: " + Summit().Price);

                    break;

                case "3":
                    deal = "Car";
                    Console.WriteLine("Class Name:" + deal);
                    Console.WriteLine("Detail is folloing - \n Maker: " + GM().Make
                        + "\n Model: " + GM().Model + "\n Year: " + GM().Year
                        + "\n Color: " + GM().Color + "\n Price: " + GM().Price);

                    break;

                default:
                    Console.WriteLine("Something is wrong.");
                    break;
            }


            Console.Read();

            Laptop Apple()
            {
                Laptop laptop = new Laptop();
                laptop.Make = "Apple";
                laptop.Model = "MacBook Air";
                laptop.Color = "Silver";
                laptop.Year = 2017;
                laptop.Price = 900.0;
                return laptop;
                }

            Refrigerator Summit()
            {
                Refrigerator refrigerator = new Refrigerator();
                refrigerator.Make = "Summit";
                refrigerator.Model = "FF1935";
                refrigerator.Color = "Silever";
                refrigerator.Year = 2018;
                refrigerator.Price = 1200.0;
                return refrigerator;
            }

            Car GM()
            {
                Car car = new Car();
                car.Make = "GM";
                car.Model = "Pontiac Trans Am";
                car.Year = 1982;
                car.Color = "Black";
                car.Price = 2000.0;
                return car;
            }

        }

        

        
    }
}
