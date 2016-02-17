using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6t3
{
    class Card
    {
        public string Suit { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            return "[" + Suit + ", " + Rank + "]";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                cards.Add(new Card { Suit = "Spades", Rank = num });
                num++;
            }

            for (int i = 14; i > 13 && 27 > i ; i++)
            {
                cards.Add(new Card { Suit = "Hearts", Rank = num });
                num++;
            }

            for (int i = 27; i > 26 && 40 > i; i++)
            {
                cards.Add(new Card { Suit = "Diamonds", Rank = num });
                num++;
            }

            for (int i = 40; i > 39 && 53 > i; i++)
            {
                cards.Add(new Card { Suit = "Clubs", Rank = num });
                num++;
            }

            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }

        }
    }
}
