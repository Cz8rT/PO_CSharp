using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            int n , minus = 0, plus = 0, zeros = 0;
            double real;
            Console.WriteLine("Podaj liczbę n: ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++){
                Console.WriteLine("Podaj element {0}: ", i + 1);
                real = double.Parse(Console.ReadLine());
                if(real > 0)
                    plus += 1;
                else if (real == 0.0)
                    zeros += 1;
                else
                    minus++;
            }

            Console.WriteLine("W podanych liczbach jest:");
            Console.Write("elementów dodatnich: ");
            Console.WriteLine(plus);
            Console.Write("elementów ujemnych: ");
            Console.WriteLine(minus);
            Console.Write("elementów zer: ");
            Console.WriteLine(zeros);

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
