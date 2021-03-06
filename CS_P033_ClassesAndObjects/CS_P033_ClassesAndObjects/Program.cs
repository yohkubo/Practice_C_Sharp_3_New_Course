﻿using System;
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
            int count = 0;
            deck.Shuffle(3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Shuffled {0} times.", count);
            Console.Read(); 
        }
    }

}
