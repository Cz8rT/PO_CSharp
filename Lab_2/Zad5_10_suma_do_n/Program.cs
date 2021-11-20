using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            static int Oblicz(int n){
            	if(n <= 1) return (1);
            	else return (n + Oblicz(n-1));  // Suma wyrazow od 1 do n
            }

            Console.WriteLine(Oblicz(5));

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
