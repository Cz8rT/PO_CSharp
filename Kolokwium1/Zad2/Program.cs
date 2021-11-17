using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Podaj pierwszą liczbę z zakresu od 0 do 10: ");
            m = Int32.Parse(Console.ReadLine());
            while (m < 0 || m > 10) {
            Console.WriteLine("Podaj poprawną pierwszą liczbę: ");
            m = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Podaj drugą liczbę z zakresu od 0 do 10: ");
            n = Int32.Parse(Console.ReadLine());
            while (n < 0 || n > 10) {
            Console.WriteLine("Podaj poprawną drugą liczbę: ");
            n = Int32.Parse(Console.ReadLine());
            }

            static int[,] do_tablicy(int m, int n){
                int[,] tablica = new int[m,n];
                for (int i = 0; i < m; i++){
                    for (int j = 0; j < n; j++){
                        Console.WriteLine("Podaj element [{0}][{1}]: ", i, j);
                        tablica[i,j] = Int32.Parse(Console.ReadLine());
                    }
                }
                return tablica;
            }

            int[,] A = do_tablicy(m, n);
            
            static int max_minus(int[,] array){
                int max = 0;
                foreach (int element in array){
                    if(element < 0 && max == 0)
                        max = element;
                    if(element < 0 && element > max)
                        max = element;
                }
                if (max == 0) {
                    Console.WriteLine("Brak ujemnego elementu w tablicy");
                    return max;
                }
                return max;
            }

            int ujemna = (max_minus(A));
            Console.WriteLine("Wynik funkcji max_minus(A)");
            Console.WriteLine(ujemna);

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
