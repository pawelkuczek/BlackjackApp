namespace BlackjackApp
{
    public interface IPlayer
    {

        string Name { get; }

        void TakeCard();

        void Pass();
        void CalculatePoints();

    }
}
