using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbę elemantów tablicy: ");
            n = Int16.Parse(Console.ReadLine());
            int[] tablica = new int[n];
            for (int i = 0; i < n; i++){
                Console.WriteLine("Podaj wartość elementu nr {0}: ", i);
                tablica[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------------------");
            foreach (int element in tablica){
                Console.WriteLine(element);
            }

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
