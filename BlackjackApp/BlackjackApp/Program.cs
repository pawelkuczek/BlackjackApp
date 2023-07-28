using BlackjackApp;
using System.Collections.Generic;

var deck = new Deck();
deck.CreateDeckOfCards();

var croupier = new Croupier("Croupier");
var player = new Player("Paweł");
var shuffledCards = croupier.ShuffleCards(deck.cards);

var croupierCards = croupier.playerCards;
var playerCards = player.playerCards;

croupier.TakeTwoCardsForPlayerAndCroupier(shuffledCards, croupierCards, playerCards);

foreach (var card in playerCards)
{
    Console.WriteLine($"{card.Value} - {card.Color}");
}

foreach (var card in croupierCards)
{
    Console.WriteLine($"{card.Value} - {card.Color}");
}

Console.WriteLine(shuffledCards.Count);