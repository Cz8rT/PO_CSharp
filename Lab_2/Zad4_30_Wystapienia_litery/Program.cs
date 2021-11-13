using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
           string tekst = "Ala ma kota";
           int liczbaZnakow = 0;
           foreach (char litera in tekst)
                if (litera == 'a') liczbaZnakow++;
            Console.WriteLine("Litara 'a' wystąpiła {0} razy.", liczbaZnakow);

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
