// Language INtegrated Query

using LInqDemo;

List<Product> s_products = new List<Product>
    {
        new( ){ Description = "Glas", Price = 3.50M },
        new( ){ Description = "Afstandsbediening", Price = 3.50M },
        new( ){ Description = "Muis", Price = 12M },
        new( ){ Description = "Monitor", Price = 170M },
        new( ){ Description = "Pen", Price = 0.20M },
        new( ){ Description = "Post-its", Price = 3.65M },
        new( ){ Description = "Rugtas", Price = 160M },
        new( ){ Description = "Dockingstation", Price = 120M },
        new( ){ Description = "Laptop", Price = 2700M },
        new( ){ Description = "Dopper", Price = 2.10M },
        new( ){ Description = "Koffie", Price = 0.90M },
        new( ){ Description = "Marker", Price = 1.40M },
        new( ){ Description = "Macbook", Price = 3400M },
        new( ){ Description = "Plant", Price = 210M },
        new( ){ Description = "Voeding", Price = 3.50M },
        new( ){ Description = "Bureaustoel", Price = 1400M },
    };

// LINQ extension methods
// .Select()
// .Where()
// .Any()
// .All()
// .TakeWhile()
// .Distinct()
// .Sum()
// .Average()
// .Max()
// .Min()
// .Count()
// .CountBy()
// .GroupBy()
// .OrderBy()
// .OrderByDescending()
// paginatie: .Skip(20 * 6).Take(20)  volgorde maakt uit

// .First() - wil 1 item, meer? eerste, minder? exception.
// .FirstOrDefault() - wil 1 item, meer? eerste, minder? null.
// .Single(x => x.Price > 100) - wil exact 1 item, anders exception. meer? exception, minder? exception.
// .SingleOrDefault()
// .Last()
// .LastOrDefault()
// .
// Nullable<int>

//List<int> bla = [104, 108, 122, 84, 11, 958];
//foreach (var item in bla.Where(x => x > 100))
//{
//    Console.WriteLine($"item: {item}");
//}

//Console.WriteLine(bla.Single(x => x > 100)); // sequence contains no element


// LINQ comprehension syntax
// - zodra het ingewikkeld wordt.
// - .Join() <== EF Core .Include().ThenInclude()...
// - ingewikkelde .GroupBy()

//var filteredProducts = from p
//                       in s_products.Where(x => x.Price < 900)
//                       where p.Price > 100
//                       select p;
//foreach (var product in filteredProducts)
//{
//    Console.WriteLine($"product: {product.Description} kost {product.Price}");
//}

Deffered.Doe();
