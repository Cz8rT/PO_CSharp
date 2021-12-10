using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static bool inside_check(double a, double b, double x){
            if (x > a && x < b)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            double a, b, x;
            Console.Write("Podaj liczbę a (lewa strona przedziału): ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę b (prawa strona przedziału): ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę x: ");
            x = double.Parse(Console.ReadLine());

            bool result = inside_check(a, b, x);
            if(result)
                Console.WriteLine("{0} należy do wskazanego przedziału!", x);
            else
                Console.WriteLine("{0} nie należy do wskazanego przedziału!", x);
                
            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}