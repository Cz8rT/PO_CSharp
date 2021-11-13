using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static int Silnia(int n)
        {
            if (n <= 1 ) return 1;
            else return n * Silnia(n-1);
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Silnia(5));

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
