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
            var listcCount = cards.Count;
            for (int i = 0; i < listcCount; i++)
            {
                var randomElementInList = random.Next(0, cards.Count);
                ShuffledCards.Add(cards[randomElementInList]);
                cards.Remove(cards[randomElementInList]);
            }
            return ShuffledCards;
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
