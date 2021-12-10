using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    public class Prostokat{
        private double dlugosc;
        private double szerokosc;
        public Prostokat(double dlugosc, double szerokosc){
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }
        private double powierzchnia(){
            return this.dlugosc * this.szerokosc;
        }
        private double obwod(){
            return 2*this.dlugosc + 2*this.szerokosc;
        }
        public void Prezentuj(){
            Console.WriteLine("Powierzchnia prostokąta: {0:0.##}, obwód: {1:0.##}", 
                this.powierzchnia(), this.obwod());
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Prostokat pr1 = new Prostokat(4.3, 6.1);
            pr1.Prezentuj();
            
            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}