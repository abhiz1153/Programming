// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.DeckOfCards
{
    /// <summary>
    /// Class for Deck Of Cards
    /// </summary>
    public class DeckOfCards
    {
        /// <summary>
        /// The cards
        /// </summary>
        private int[,] cards = new int[4, 13];
        /// <summary>
        /// The rand
        /// </summary>
        private Random rand = new Random();
        /// <summary>
        /// The player
        /// </summary>
        private int player = 1;
        /// <summary>
        /// Suits the specified suits.
        /// </summary>
        /// <param name="suits">The suits.</param>
        /// <returns></returns>
        public static string Suit(int suits)
        {
            switch (suits)
            {
                case 0:
                     return "Clubs";
                case 1:
                    return "Diamond";
                case 2:
                    return "Heart";
                case 3:
                    return "Spade";
                default:
                    return "In Switch (default)";
            }
        }
        /// <summary>
        /// Ranks the specified ranks.
        /// </summary>
        /// <param name="ranks">The ranks.</param>
        /// <returns></returns>
        public static string Rank(int ranks)
        {
            switch (ranks)
            {
                case 0:
                    return "2";
                case 1:
                    return "3";
                case 2:
                    return "4";
                case 3:
                    return "5";
                case 4:
                    return "6";
                case 5:
                    return "7";
                case 6:
                    return "8";
                case 7:
                    return "9";
                case 8:
                    return "10";
                case 9:
                    return "Jack";
                case 10:
                    return "Queen";
                case 11:
                    return "King";
                case 12:
                    return "Ace";              
                default:
                    return "In Switch (default)";
            }
        }
        /// <summary>
        /// Initializes the card.
        /// </summary>
        public void InitializeCard()
        {
            for (int playernumber = 1; playernumber <=4; playernumber++)
            {
                DistributeCard(playernumber);
                Console.WriteLine("Player " + player);
                player++;
                Console.WriteLine("_______________________________________________________________");
                Print(playernumber);
                Console.WriteLine("_______________________________________________________________");
            }
        }
        /// <summary>
        /// Distributes the card.
        /// </summary>
        /// <param name="playernumber">The playernumber.</param>
        public void DistributeCard(int playernumber)
        {
            for(int i = 0; i < 9; i++)
            {
                SuffleCard(playernumber);

            }
        }
        /// <summary>
        /// Suffles the card.
        /// </summary>
        /// <param name="playernumber">The playernumber.</param>
        public void SuffleCard(int playernumber)
        {
            int suit = rand.Next(1, 4);
            int rank = rand.Next(0, 13);
            if (cards[suit, rank] == 0)
            {
                cards[suit, rank] = playernumber;
                return;
            }
            else
                SuffleCard(playernumber);

        }
        /// <summary>
        /// Prints the specified playernumber.
        /// </summary>
        /// <param name="playernumber">The playernumber.</param>
        public void Print(int playernumber)
        {
            int suitLength = cards.GetLength(0);
            int rankLength = cards.GetLength(1);
            for (int suits = 0; suits < suitLength; suits++)
                for (int ranks = 0; ranks < rankLength; ranks++)
                    if (cards[suits, ranks] == playernumber)
                        Console.WriteLine(Suit(suits) + " " + Rank(ranks));
        }
    }
}







