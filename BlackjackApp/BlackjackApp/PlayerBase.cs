namespace BlackjackApp
{
    public abstract class PlayerBase : IPlayer
    {
        public List<Card> playerCards = new List<Card>();

        public PlayerBase(string name)
        {
            this.Name = name;

        }
        public string Name { get; set; }

        public int CalculatePoints(List<Card> playerCards)
        {
            int playerResult = 0;

            foreach (var card in playerCards)
            {
                if (int.TryParse(card.Value, out int result))
                {
                    playerResult += result;
                }
                else if (card.Value == "Walet" || card.Value == "Dama" || card.Value == "Król")
                {
                    playerResult += 10;
                }
                else if (card.Value == "As")
                {
                    playerResult += 11;
                }
                else
                {
                    throw new Exception("Wrong card value");
                }
            }
            return playerResult;
        }


        public abstract void Pass();


        public abstract void TakeCard();

    }
}
