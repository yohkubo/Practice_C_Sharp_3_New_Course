using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();

            Player player = new Player() {Name = "Jesse" };
            //game += player;
            game.ListPlayers();
            Console.ReadLine();
            

            //game.ListPlayers();


            //Deck deck = new Deck();
            //int count = 0;
            //deck.Shuffle(3);

            //TwentyOneGame twentyOneGame = new TwentyOneGame();  


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Shuffled {0} times.", count);
            //Console.Read();
        }
    }
}
