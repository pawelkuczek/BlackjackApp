namespace BlackjackApp
{
    public interface IPlayer
    {

        string Name { get; }

        void TakeCard(List<Card> shuffledCards, List<Card> cards);
        int CalculatePoints(List<Card> playerCards);

    }
}
