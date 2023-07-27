namespace BlackjackApp
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        readonly List<string> possibleCardColors = new List<string>() { "kier", "karo", "trefl", "pik" };
        readonly List<string> possibleCardValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Walet", "Dama", "Król", "As" };

        public void CreateDeckOfCards()
        {

            foreach (var color in this.possibleCardColors)
            {
                foreach (var value in this.possibleCardValues)
                {
                    this.cards.Add(new Card(color, value));
                }
            }
        }
    }
}
