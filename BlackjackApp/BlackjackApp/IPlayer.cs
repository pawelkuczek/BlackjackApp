namespace BlackjackApp
{
    public interface IPlayer
    {

        string Name { get; }

        void TakeCard(List<Card> shuffledCards, List<Card> cards);
        void CalculatePoints(List<Card> playerCards);

        void CheckForTwoAcesWin(List<Card> playerCards, string playerName);

        void ShowWinningMessage(int playerResult, int croupierResult, string playerName, List<Card> playerCards);

    }
}
