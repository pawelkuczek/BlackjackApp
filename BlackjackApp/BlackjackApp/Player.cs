namespace BlackjackApp
{
    public class Player : PlayerBase
    {
        public Player(string name) : base(name) { }

        public void PlayerPlays(List<Card> shuffledCards, string playerName, List<Card> playerCards)

        {
            Player newPlayer = new Player(playerName);
            var playerPoints = newPlayer.CalculatePoints(playerCards);


            while (true)
            {
                Console.WriteLine("Twoje karty:");

                foreach (var card in playerCards)
                {
                    Console.WriteLine($"{card.Value} - {card.Color}");
                }
                Console.WriteLine($"Punkty gracza");
                Console.WriteLine(playerPoints);

                Console.WriteLine("Wybierz: ");
                Console.WriteLine("1 - aby dobrać kartę ");
                Console.WriteLine("0 - aby spasować");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    newPlayer.TakeCard(shuffledCards, playerCards);
                    playerPoints = newPlayer.CalculatePoints(playerCards);
                }
                else if (input == "0")
                {
                    break;
                }
                else
                {
                    throw new Exception("Nieprawidłowy wybór, spróbuj jeszcze raz");
                    
                }
                Console.WriteLine("-----------------");
            }
        }
    }
}




