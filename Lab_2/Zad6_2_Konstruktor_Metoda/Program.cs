using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    public class Pracownik{
        public string nazwisko;
        private double zarobki;

        public Pracownik(string n, double z){       // Konstruktor
            nazwisko = n;
            zarobki = z;
        }
        public void PokazPracownika(){              // Metoda
            Console.WriteLine("{0,-15} {1,10}", nazwisko, zarobki);
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Kolo", 2600);
            p1.PokazPracownika();

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
