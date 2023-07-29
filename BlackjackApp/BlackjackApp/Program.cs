using BlackjackApp;
using System.Collections.Generic;

Console.WriteLine("Blackjack");
Console.WriteLine("Wpisz imię gracza: ");
var playerName = Console.ReadLine();
Console.WriteLine("-----------------");
var player = new Player(playerName);

var deck = new Deck();

deck.CreateDeckOfCards();

var croupier = new Croupier("Croupier");

var croupierCards = new List<Card>();  
var playerCards = new List<Card>(); 

var shuffledCards = croupier.ShuffleCards(deck.cards);

Console.WriteLine("Krupier tasuje karty");
await Task.Delay(2000);
Console.WriteLine("Krupier rozdaje karty");
await Task.Delay(2000);
Console.WriteLine("-----------------");
croupier.TakeTwoCardsForPlayerAndCroupier(shuffledCards, croupierCards, playerCards);
croupier.CalculatePoints(croupierCards);
player.CalculatePoints(playerCards);




while (true)

{
    player.CheckForTwoAcesWin(playerCards, player.Name);
    croupier.CheckForTwoAcesWin(croupierCards, croupier.Name);


    Console.WriteLine("Twoje karty:");

    foreach (var card in playerCards)
    {
        Console.WriteLine($"[{card.Value} - {card.Color}]");
    }
    Console.WriteLine($"Punkty gracza: {player.playerResult}");
    Console.WriteLine($"Punkty krupiera: {croupier.playerResult}");
    Console.WriteLine("-----------------");

    if (croupier.playerResult == 21)
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Wygrywa krupier.");
        break;
    }

    if (player.playerResult == 21)
    {
        Console.WriteLine("-----------------");
        Console.WriteLine($"Wygrywa {playerName}");
        break;
    }



    Console.WriteLine("Wybierz: ");
    Console.WriteLine("1 - aby dobrać kartę ");
    Console.WriteLine("0 - aby spasować");
    var input = Console.ReadLine();

    if (input == "1")
    {
        player.TakeCard(shuffledCards, playerCards);
        player.playerResult = 0;
        player.CalculatePoints(playerCards);
       
    }
  
    else if (input == "0" && player.playerResult < croupier.playerResult)
    {
        croupier.ShowWinningMessage(player.playerResult, croupier.playerResult, player.Name, playerCards);
        break;

    }

    else if (input == "0" && player.playerResult > croupier.playerResult)
    {
        player.ShowWinningMessage(player.playerResult, croupier.playerResult, player.Name, playerCards);
        break;

    }
    else if (input == "0" && player.playerResult == croupier.playerResult)
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Wygrywa krupier. Gracz spasował.");
        Console.WriteLine($"Punkty gracza: {player.playerResult}");
        Console.WriteLine($"Punkty krupiera: {croupier.playerResult}");
        break;
    }
    else
    {
        throw new Exception("Nieprawidłowy wybór, spróbuj jeszcze raz");

    }

    if (croupier.playerResult <= 17) {

        croupier.TakeCard(shuffledCards, croupierCards);
        croupier.playerResult = 0;
        croupier.CalculatePoints(croupierCards);
    }
    
    
    if (croupier.playerResult > 21 || player.playerResult == 21)
    {
        player.ShowWinningMessage(player.playerResult, croupier.playerResult, player.Name, playerCards);
        break;
    }
    if (player.playerResult > 21 || croupier.playerResult == 21)
    {
        croupier.ShowWinningMessage(player.playerResult, croupier.playerResult, player.Name, playerCards);

        break;
    }
    if (player.playerResult == 20 && croupier.playerResult == 20)
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Remis");
        Console.WriteLine($"Punkty {player.Name}: {player.playerResult}");
        Console.WriteLine($"Punkty krupiera: {croupier.playerResult}");

        break;
    }

    Console.WriteLine("-----------------");
}
        

