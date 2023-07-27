namespace BlackjackApp
{
    public abstract class PlayerBase : IPlayer
    {
        public PlayerBase(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public abstract void CalculatePoints();

        public abstract void Pass();


        public abstract void TakeCard();
       
    }
}
