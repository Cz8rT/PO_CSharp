using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, wynik = 0;
            bool safety = true;
            string znak;
            Console.WriteLine("Kalkulator! Kalkulator!.");
            Console.Write("Podaj pierwszą liczbę: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Podaj znak działania [+ - * /]: ");
            znak = Console.ReadLine();

            switch (znak) {
                case ("+"):
                    wynik = x + y;
                    break;
                case ("-"):
                    wynik = x - y;
                    break;
                case ("*"):
                    wynik = x * y;
                    break;
                case ("/"):
                    wynik = x / y;
                    break;
                default:
                    safety = false;
                    Console.WriteLine("Podano błędny znak działania!");
                    break;
            }

            if (safety)
                Console.WriteLine("Wynik działania to: " + wynik);
            
            var machine = System.Environment.MachineName;
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
