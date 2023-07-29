namespace BlackjackApp
{
    public class Player : PlayerBase
    {
        public Player(string name) : base(name) { }

        override public void CheckForTwoAcesWin(List<Card> playerCards, string playerName)
        {
            foreach (var card in playerCards)
            {
                var aces = new List<Card>();
                if (card.Value == "As")
                {
                    aces.Add(card);
                }

                if (aces.Count == 2)
                {
                    Console.WriteLine($"Wygrywa {playerName}. Trafiono 2 asy.");
                    break;
                }

            }
        }

        override public void ShowWinningMessage(int playerResult,int croupierResult, string playerName, List<Card> playerCards)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Wygrywa {playerName}");
            Console.WriteLine("Twoje karty:");

            foreach (var card in playerCards)
            {
                Console.WriteLine($"[{card.Value} - {card.Color}]");
            }
            Console.WriteLine($"Punkty {playerName}: {playerResult}");
            Console.WriteLine($"Punkty krupiera: {croupierResult}");
        }
    }
}




