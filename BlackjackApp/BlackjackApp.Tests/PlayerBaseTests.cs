namespace BlackjackApp.Tests
{
    public class PlayerBaseTests
    {
        [Test]
        public void WhenCalculatePointsCalled_ShouldReturnCorrectException()
        {
            //arrange
            var player = new Player("Paweł");
            var cards = new List<Card>() { new Card("Karo", "dwa"), };


            //act
            try
            {
                player.CalculatePoints(cards);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Wrong card value", ex.Message);
            }

            //assert

        }

        [Test]
        public void WhenCalculatePointsCalled_ShouldReturnCorrectSum()
        {
            //arrange
            var player = new Player("Paweł");
            var cards = new List<Card>() {
                new Card("Karo", "2"),
                new Card("Karo", "3"),
                new Card("Karo", "4"),
                new Card("Karo", "5"),
                new Card("Karo", "6"),
                new Card("Karo", "7"),
                new Card("Karo", "8"),
                new Card("Karo", "9"),
                new Card("Karo", "10"),
                new Card("Karo", "Walet"),
                new Card("Karo", "Dama"),
                new Card("Karo", "Król"),
                new Card("Karo", "As"),
            };


            //act


            var sum = player.CalculatePoints(cards);


            //assert
            Assert.AreEqual(95, sum);
        }

        [Test]
        public void WhenTakeCard_ShouldReturnCorrectValue()
        {
            //arrange
            var player = new Player("Paweł");
            var cards1 = new List<Card>() { new Card("Karo", "10"), };
            var cards2 = new List<Card>();
         
            //act
     
            player.TakeCard(cards1, cards2);

            //assert
            Assert.AreEqual(0, cards1.Count);
            Assert.AreEqual(1, cards2.Count);
            Assert.AreEqual("10", cards2[0].Value);
        }
    }
}
