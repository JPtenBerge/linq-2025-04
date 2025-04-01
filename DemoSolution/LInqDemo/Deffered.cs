using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqDemo;

class Deffered
{


    public static void Doe()
    {
        foreach (var item in Geef())
        {
            Console.WriteLine($"item: {item}");
        }
    }

    public static IEnumerable<int> Geef()
    {
        Console.WriteLine("eerste");
        yield return 4;
        Console.WriteLine("tweede");
        yield return 8;
        Console.WriteLine("derde");
        yield return 15;
        Console.WriteLine("vierde");
        yield return 16;
        Console.WriteLine("vijfde");
        yield return 23;
        Console.WriteLine("zesde");
        yield return 42;
    }
}
