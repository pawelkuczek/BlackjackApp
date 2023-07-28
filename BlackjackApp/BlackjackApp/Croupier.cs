using System.Collections.Generic;

namespace BlackjackApp
{
    public class Croupier : PlayerBase
    {
        public Croupier(string name) : base(name) { }

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
        public override void CalculatePoints()
        {
            throw new NotImplementedException();
        }

        public override void Pass()
        {
            throw new NotImplementedException();
        }

        public override void TakeCard()
        {
            throw new NotImplementedException();
        }
    }
}
