namespace BlackjackApp.Tests
{
    public class CroupierTests
    {
        [Test]
        public void WhenShuffleCardsCalled_ShouldReturnCorrectCount()
        {
            //arrange
            var deck = new Deck();
            var croupier = new Croupier("Croupier");

            //act
            deck.CreateDeckOfCards();
            var shuffledCards = croupier.ShuffleCards(deck.cards);

            //assert
            Assert.AreEqual(52, shuffledCards.Count);
        }

        [Test]
        public void WhenShuffleCardsCalled_ShouldReturnCorrectCountOfEachColor()
        {
            //arrange
            var deck = new Deck();
            var croupier = new Croupier("Croupier");
            var countKier = new List<Card>();
            var countKaro = new List<Card>();
            var countTrefl = new List<Card>();
            var countPik = new List<Card>();

            //act
            deck.CreateDeckOfCards();
            var shuffledCards = croupier.ShuffleCards(deck.cards);

            foreach (var card in shuffledCards)
            {
                if (card.Color == "kier")
                {
                    countKier.Add(card);
                }
                else if (card.Color == "karo")
                {
                    countKaro.Add(card);
                }
                else if (card.Color == "trefl")
                {
                    countTrefl.Add(card);
                }
                else
                {
                    countPik.Add(card);
                }

            }

            //assert
            Assert.AreEqual(13, countKier.Count);
            Assert.AreEqual(13, countKaro.Count);
            Assert.AreEqual(13, countTrefl.Count);
            Assert.AreEqual(13, countPik.Count);
        }
    }
}