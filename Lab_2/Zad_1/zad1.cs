using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Sprawdźmy czy podany rok jest przestępny.");
            Console.Write("Podaj rok: ");
            rok = int.Parse(Console.ReadLine());
            if (rok % 400 == 0 || rok % 4 == 0 && rok % 100 != 0) {
                Console.WriteLine("Podany rok jest przestępny.");
            } else {
                Console.WriteLine("Podany rok nie jest przestępny.");
            }
            
            var machine = System.Environment.MachineName;
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
