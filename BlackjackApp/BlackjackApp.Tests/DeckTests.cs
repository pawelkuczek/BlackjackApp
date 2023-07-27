namespace BlackjackApp.Tests
{
    public class DeckTests
    {
        [Test]
        public void WhenCreateDeckOfCardsCalled_ShouldReturnCorrectCount()
        {
            //arrange
            var deck = new Deck();

            //act
            deck.CreateDeckOfCards();

            //assert
            Assert.AreEqual(52, deck.cards.Count);
        }

        [Test]
        public void WhenCreateDeckOfCardsCalled_ShouldReturnCorrectCountOfEachColor()
        {
            //arrange
            var deck = new Deck();
            var countKier = new List<Card>();
            var countKaro = new List<Card>();
            var countTrefl = new List<Card>();
            var countPik = new List<Card>();


            //act
            deck.CreateDeckOfCards();
            foreach (var card in deck.cards)
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