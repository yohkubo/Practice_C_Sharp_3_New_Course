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
            deck = Shuffle(deck);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read(); 

        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0)
            {
                int num = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[num]);
                deck.Cards.RemoveAt(num);
            }
            deck.Cards = TempList;
            return deck;
        }
    }

}
