using System;
namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord tack");
            string ord = Console.ReadLine();
            Console.WriteLine("Skriv in två tecken du vill att programmet ska leta efter i ditt ord");
            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();

            if (ord.Contains(ord1) && ord.Contains(ord2))
            {
                Console.WriteLine($"{ord} innehåller {ord1} och {ord2}");
            }
            else if (ord.Contains(ord1))
            {
                Console.WriteLine($"{ord} innehåller {ord1} men inte {ord2}");
            }
            else if (ord.Contains(ord2))
            {
                Console.WriteLine($"{ord} innehåller {ord2} men inte {ord1}");
            }
            else
            {
                Console.WriteLine($"{ord} innehåller varken {ord1} eller {ord2}");
            }
            Console.ReadKey();
        }
    }
}