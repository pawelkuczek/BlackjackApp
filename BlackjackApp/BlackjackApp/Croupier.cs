using System.Collections.Generic;

namespace BlackjackApp
{
    public class Croupier : PlayerBase
    {
        public Croupier(string name) : base(name)
        {

        }

        public List<Card> ShuffleCards(List<Card> cards)
        {
            var random = new Random();
            var ShuffledCards = new List<Card>();
            var cardsCount = cards.Count;
            for (int i = 0; i < cardsCount; i++)
            {
                var randomElementInList = random.Next(0, cards.Count);
                ShuffledCards.Add(cards[randomElementInList]);
                cards.Remove(cards[randomElementInList]);
            }
            return ShuffledCards;
        }

        public void TakeTwoCardsForPlayerAndCroupier(List<Card> shuffledCards, List<Card> croupierCards, List<Card> playerCards)
        {
            croupierCards.Add(shuffledCards[0]);
            shuffledCards.RemoveAt(0);
            playerCards.Add(shuffledCards[0]);
            shuffledCards.RemoveAt(0);
            croupierCards.Add(shuffledCards[0]);
            shuffledCards.RemoveAt(0);
            playerCards.Add(shuffledCards[0]);
            shuffledCards.RemoveAt(0);

        }
        override public void ShowWinningMessage(int playerResult, int croupierResult, string playerName, List<Card> playerCards)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Wygrywa krupier.");
            Console.WriteLine($"Punkty gracza: {playerResult}");
            Console.WriteLine($"Punkty krupiera: {croupierResult}");
        }

        override public void CheckForTwoAcesWin(List<Card> playerCards, string playerName)
        {
            foreach (var card in playerCards)
            {
                var aces = new List<Card>();
                if (card.Value == "As")
                {
                    aces.Add(card);
                }

                if (aces.Count == 2)
                {
                    Console.WriteLine($"Wygrywa krupier. Trafiono 2 asy.");
                    break;
                }

            }
        }
    }
}