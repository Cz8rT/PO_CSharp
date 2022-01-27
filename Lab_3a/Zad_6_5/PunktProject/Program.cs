using System;
using System.Collections.Generic;
using System.Globalization;

namespace PunktProject
{
    internal class Program
    {
        public class Punkt {

            public double x;
            public double y;

            public Punkt(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public void Przesun(double dx, double dy)
            {
                this.x += dx;
                this.y += dy;
            }

            public void Wyswietl()
            {
                Console.WriteLine("Współrzędne punktu: x =  {0}, y = {1}", x, y);
            }
        }
    static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt(1, 2);
            punkt1.Wyswietl();
            punkt1.Przesun(-3.4, 2.2);
            punkt1.Wyswietl();


            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}