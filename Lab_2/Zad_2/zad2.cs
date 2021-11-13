using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Czy druga liczba jest dzielnikiem pierwszej? Sprawdźmy!.");
            Console.Write("Podaj pierwszą liczbę: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            y = int.Parse(Console.ReadLine());
            if (x % y == 0){
                Console.WriteLine("Liczba " + y + " jest dzielnikiem liczby " + x + ".");
            } else {
                Console.WriteLine("Liczba " + y + " nie jest dzielnikiem liczby " + x + ".");
            }

            var machine = System.Environment.MachineName;
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
