using BlackjackApp;
using System.Collections.Generic;

var deck = new Deck();
deck.CreateDeckOfCards();


foreach (var card in deck.cards)
{
    Console.WriteLine($"{card.Value} - {card.Color}");
}
