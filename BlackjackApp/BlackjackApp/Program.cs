using BlackjackApp;
using System.Collections.Generic;

Console.WriteLine("Test playera");
Console.WriteLine("Wpisz imię gracza: ");
var playerName = Console.ReadLine();
Console.WriteLine("-----------------");
var player = new Player(playerName);

var deck = new Deck();

deck.CreateDeckOfCards();

var croupier = new Croupier("Grzegorz");

var croupierCards = new List<Card>();  
var playerCards = new List<Card>(); 

var shuffledCards = croupier.ShuffleCards(deck.cards);

croupier.TakeTwoCardsForPlayerAndCroupier(shuffledCards, croupierCards, playerCards);

player.PlayerPlays(shuffledCards, playerName, playerCards);






//var deck = new Deck();
//deck.CreateDeckOfCards();

//var croupier = new Croupier("Croupier");
//var player = new Player("Paweł");
//var shuffledCards = croupier.ShuffleCards(deck.cards);

//var croupierCards = croupier.playerCards;
//var playerCards = player.playerCards;

//croupier.TakeTwoCardsForPlayerAndCroupier(shuffledCards, croupierCards, playerCards);

//foreach (var card in playerCards)
//{
//    Console.WriteLine($"{card.Value} - {card.Color}");
//}

//foreach (var card in croupierCards)
//{
//    Console.WriteLine($"{card.Value} - {card.Color}");
//}

//var croupierPoints = croupier.CalculatePoints(croupierCards);

//Console.WriteLine(croupierPoints);