using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasDemo;

class ProductViewer
{

    delegate int Bla(int id);


    static List<Product> s_products = new List<Product>
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

    public static void Doe()
    {
        PrintExpensiveProducts();
        PrintProductsWhoseDescriptionStartWith("M");

        Console.WriteLine("============");

        Predicate<Product> expensiveProductPred = delegate (Product product)
        {
            return product.Price > 100M;
        };
        Predicate<Product> expensiveProductPred2 = p => p.Price > 100M;

        PrintFilteredProducts(p => p.Price > 100M, p => Console.WriteLine($"Prowwwwwwduct {p.Description} kost EUR {p.Price}"));
        PrintFilteredProducts(p => p.Description.StartsWith("M"), p => Console.WriteLine($"Produqqqqqqqqct {p.Description} kost EUR {p.Price} en begint met een M"));
    }

    public static void PrintFilteredProducts(Predicate<Product> pred, Action<Product> printer)
    {
        foreach (var product in s_products)
        {
            if (pred.Invoke(product))
            {
                printer(product);
            }
        }
    }

    public static void PrintExpensiveProducts()
    {
        foreach (var product in s_products)
        {
            if (product.Price > 100M)
            {
                Console.WriteLine($"Product {product.Description} kost EUR {product.Price}");
            }
        }
    }

    public static void PrintProductsWhoseDescriptionStartWith(string letter)
    {
        foreach (var product in s_products)
        {
            if (product.Description.StartsWith(letter))
            {
                Console.WriteLine($"Product {product.Description} kost EUR {product.Price} en begint met {letter}");
            }
        }
    }
}
