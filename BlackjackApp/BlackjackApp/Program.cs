using BlackjackApp;
using System.Collections.Generic;

var deck = new Deck();
deck.CreateDeckOfCards();

var croupier = new Croupier("Croupier");
var shuffledCards = croupier.ShuffleCards(deck.cards);

foreach (var shuffledCard in shuffledCards)
{
    Console.WriteLine($"{shuffledCard.Value} - {shuffledCard.Color}");
}

Console.WriteLine(shuffledCards.Count );
//foreach (var card in deck.cards)
//{
//    Console.WriteLine($"{card.Value} - {card.Color}");
//}


