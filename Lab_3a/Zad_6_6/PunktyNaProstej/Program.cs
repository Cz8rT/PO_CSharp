using System;
using System.Collections.Generic;
using System.Globalization;

namespace PunktyNaProstej
{
    internal class Program
    {
        public class Punkt
        {

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
            List<Punkt> punkty = new List<Punkt>() {new Punkt(1,1), 
                                                    new Punkt(2, 2), 
                                                    new Punkt(3, 3)};
            if (PunktyNaProstej(punkty))
            {
                Console.WriteLine("Punkty leżą na jednej prostej.");
            }
            else
            {
                Console.WriteLine("Punkty nie leżą na jednej prostej!");
            }

            static bool PunktyNaProstej(List<Punkt> pointList)
            {
                double x1 = pointList[0].x, y1 = pointList[0].y, 
                       x2 = pointList[1].x, y2 = pointList[1].y, 
                       x3 = pointList[2].x, y3 = pointList[2].y;
                try
                {
                    double b = (y2 * x1 - y1 * x2) / (x1 - x2);
                    double a = (y1 - b) / x1;
                    if (a * x3 + b == y3) return true;
                    return false;
                } 
                catch(DivideByZeroException error)
                {
                    Console.WriteLine(error.Message);
                    return false;
                }   
            }

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
