using System;
using System.Collections.Generic;
using System.Globalization;
namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            double[,] tablica = new double[5,5];

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    Console.WriteLine("Podaj element [{0}][{1}]: ", i, j);
                    tablica[i,j] = double.Parse(Console.ReadLine());
                }
            }

            double sum = 0.0;

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    Console.Write("{0}", tablica[i,j]);
                    Console.Write(" ");
                    if (i == j)
                        sum += tablica[i,j];
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Suma elementów przekątnej: {0}", sum);

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
