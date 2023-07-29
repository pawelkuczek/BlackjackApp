namespace BlackjackApp
{
    public abstract class PlayerBase : IPlayer
    {
       
        public int playerResult = 0;
        public PlayerBase(string name)
        {
            this.Name = name;

        }
        public string Name { get; set; }

        public void CalculatePoints(List<Card> playerCards)
        {
            foreach (var card in playerCards)
            {
                if (int.TryParse(card.Value, out int result))
                {
                    this.playerResult += result;
                }
                else if (card.Value == "Walet" || card.Value == "Dama" || card.Value == "Król")
                {
                    this.playerResult += 10;
                }
                else if (card.Value == "As")
                {
                    this.playerResult += 11;
                }

                else
                {
                    throw new Exception("Wrong card value");
                }
            }
        }


        public void TakeCard(List<Card> shuffledCards, List<Card> cards)
        {
            cards.Add(shuffledCards[0]);
            shuffledCards.RemoveAt(0);
     
        }

        abstract public void CheckForTwoAcesWin(List<Card> playerCards, string playerName);
        abstract public void ShowWinningMessage(int playerResult, int croupierResult, string playerName, List<Card> playerCards);
    }
}
