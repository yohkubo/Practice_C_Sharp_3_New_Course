﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Deck
    {
        public Deck()
        {
            this.Cards = new List<Card>();
            List<string> Suits = new List<string>
                { "Clubs", "Spades", "Hearts", "Diamonds" };
            List<string> Faces = new List<string>
                { "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }

        }

        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int num = random.Next(0, Cards.Count);
                    TempList.Add(Cards[num]);
                    Cards.RemoveAt(num);
                }
                this.Cards = TempList;
            }

        }
    }
}
