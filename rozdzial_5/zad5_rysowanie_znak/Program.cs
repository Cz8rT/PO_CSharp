using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            static void rysuj(int dlugosc, int szerokosc, char znak = '*'){
            	for(int i = 0; i < szerokosc; i++){
                    for(int j = 0; j < dlugosc; j++){
                        Console.Write(znak);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            rysuj(6, 3, '*');
            rysuj(3, 6);
            rysuj(4, 4, '@');

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}