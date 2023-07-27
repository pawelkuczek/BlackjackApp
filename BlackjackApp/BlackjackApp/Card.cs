using System.Runtime.CompilerServices;

namespace BlackjackApp
{
    public class Card
    {
        public Card(string color, string value)
        {
            this.Color = color;
            this.Value = value;
        }

        public string Color { get; private set; }

        public string Value { get; private set; }


    }
}
