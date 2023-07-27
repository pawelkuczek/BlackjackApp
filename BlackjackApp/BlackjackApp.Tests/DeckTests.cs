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
    }
}