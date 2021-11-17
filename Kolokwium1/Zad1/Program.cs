using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj napis: ");
            string napis = Console.ReadLine();

            static void liczba_wystapien(string napis){
                int countA = 0;
                int countB = 0;
                char a = 'a';
                char b = 'b';
                
                foreach (char litera in napis) {
                    if (litera == a) countA++;
                    if (litera == b) countB++;
                }
                Console.WriteLine("Łączna liczba wystąpień liter a i b: {0}", countA + countB);
            }

            static string odwroc(string napis){
                string odwrocony = "";
                for (int i = napis.Length - 1; i >= 0; i--)
                    odwrocony += napis[i];
                return odwrocony;
            }

            liczba_wystapien(napis);
            Console.WriteLine(odwroc(napis));

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
