using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    public class Car{
        public static int iloscKol;     // pole statyczne
        public static int liczbaAut;     // pole statyczne
        private double pojemnoscSilnika;
        private string marka;

        private Car(double pojemnoscSilnika, string marka){  // konstruktor
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        static Car(){   // konstruktor statyczny
            iloscKol = 4;
            liczbaAut = 0;
        }

        public void ShowMarka(){
            Console.WriteLine(this.marka);
        }
        public static Car Create(double pojemnoscSilnika, string marka){  // metoda
            liczbaAut++;
            return new Car(pojemnoscSilnika, marka);
        }

        ~Car(){
            Console.WriteLine("Zwalniam pamiec");
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Car car1 = Car.Create(1.99, "Honda");
            car1.ShowMarka();
                
            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}