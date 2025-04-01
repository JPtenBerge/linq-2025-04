// See https://aka.ms/new-console-template for more information
using PreknowledgeDemo;

Console.WriteLine("Hello, World!");

// COM-objecten
//dynamic bla = null;
//bla.LadiedaBlabla(14, 28, "hoi");


var getallen = 1483848292949393.384;
//getal = "qweer";

//var bla; // efficient keyword
//IEnumerable<ProductModel>

//if (true)
//{
//bla = 4;
//}
//else
//{
//    bla = "hoi";
//}

// one-liners
// one-liners met LINQ
// configuration
// LINQ - .Select(x => new { x... })   map
// EF Core - entity.HasKey(x => new { x.DingId, x.BlaId })
var x = new
{
    Bla = 14,
    Hoi = "iets",
    Bla2 = new List<int> { 1, 2, 3 }
};
var y = new
{
    Bla21345 = 14,
    Hoi = "iets",
    Bla2 = new List<int> { 1, 2, 3 }
};


var tupletje = (14, 28);

var returnValues = DoeIets();
var (eerste, tweede) = DoeIets();
Console.WriteLine($"returnvalues: {eerste} / {tweede}");


// waar te gebruiken: plekken waar je meerdere dingen wil returnen
// LINQ? nope.
// ASP.NET Core - DTO - nope.
// servicelaagjes/repositories
static (int Bladiebla, string Hatseflats) DoeIets()
{
    return (42, "hoi");
}

// extension methods?
// - LINQ   IEnumerable<T>  .Select() .ToList()
// - ASP.NET Core   builder.Services.Add...()  app.Map.....
// - AwesomeAssertions  unittesten  Assert.AreEqual(14, sut.Bla())   sut.Bla().Should().Be(14);
// - Flurl - "https://mijndomein.nl/api/bla".WitHHeader("Authorization", "Bearer ...").PostAsJsonAsync(dto).ReceiveJson<BlaDto>()

Console.WriteLine(DateTime.Now.ToPrettyString());