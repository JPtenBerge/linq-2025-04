// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//System.Collections.Concurrent.list


ICollection<int> bla = new List<int>();

var listje = new LinkedList<int>();
//listje[4]

// key-value pair
var dict = new Dictionary<char, int>();
var tekst = "hallo ik ben jp en ik geef training";
foreach(var character in tekst)
{
    if(!dict.ContainsKey(character))
    {
        dict.Add(character, 0);
    }
    dict[character]++;
}
foreach(var (key, value) in dict) // <== enumereren
{
    Console.WriteLine($"{key} komt {value} keer voor");
}
