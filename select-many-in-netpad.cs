// .SelectMany(), ook wel de FLatMap

var a = new Player();
a.Cards.Add(new Card { Suit = "heart", Value = 10 });
a.Cards.Add(new Card { Suit = "heart", Value = 11 });
var b = new Player();
b.Cards.Add(new Card { Suit = "diamond", Value = 10 });
b.Cards.Add(new Card { Suit = "diamond", Value = 11 });
var c = new Player();
c.Cards.Add(new Card { Suit = "club", Value = 11 });
c.Cards.Add(new Card { Suit = "club", Value = 12 });

var players = new List<Player> { a, b, c };
players.SelectMany(x => x.Cards).Dump();

class Player
{
    public List<Card> Cards { get; set; } = new();
}
class Card
{
    public string Suit { get; set; }
    public int Value { get; set; }
}