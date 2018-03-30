using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P039_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deal class is to calculate how many pizza you need for a party.

            Deal deal = new Deal();
            bool vali = false;

            while(vali == false)
            {
                try
                {
                Console.WriteLine("You have a party today. You need some pizza." +
                    "\nHow many friends are coming?");
                int friends = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("(Optional)How many slices do you think each person " +
                    "could eat?");
                int slices;

                if (int.TryParse(Console.ReadLine(), out slices) && slices > 0)
                    Console.WriteLine("You have {0} friends, who could eat {1} " +
                        "slices of pizza for today's party. You've got to get {2} of pizza.", 
                    friends, slices, deal.Pizza(friends, slices));

                else
                    Console.WriteLine("You have {0} friends for today's party. " +
                        "You've got to get {1} of pizza.",
                             friends, deal.Pizza(friends:friends));

                vali = true;

                Console.ReadLine();
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + "\nTry again.\n");
                }

            }
        }
    }
}
