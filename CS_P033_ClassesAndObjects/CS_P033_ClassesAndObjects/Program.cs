using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P033_ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            int count = 0;
            deck = Shuffle(deck, out count, 3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Shuffled {0} times.", count);
            Console.Read(); 

        }

        public static Deck Shuffle(Deck deck, out int count, int times = 1)
        {
            count = 0;
            for(int i = 0; i < times; i++)
            {
                count++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while(deck.Cards.Count > 0)
                {
                    int num = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[num]);
                    deck.Cards.RemoveAt(num);
                }
                deck.Cards = TempList;
            }
            return deck;
        }


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    int count=0;
        //    for(int i=0; i < times; i++)
        //    {
        //        count++;
        //        deck = Shuffle(deck);
        //    }
        //    Console.WriteLine("Shuffeled {0} times.", count);
        //    return deck;
        //}
    }

}
