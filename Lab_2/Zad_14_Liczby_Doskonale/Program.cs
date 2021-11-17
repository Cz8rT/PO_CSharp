using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbę 'n': ");
            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nLiczby doskonałe z zakresu od 1 do {0}", n);

            for(int i = 2; i <= n; i++){
                int sum = 0;
                List<int> deviders = new List<int>();
                for(int j = 1; j <= i - 1; j++){
                    if(i % j == 0)
                        deviders.Add(j);
                }
                foreach(int element in deviders)
                    sum += element;
                if(sum == i)
                    Console.WriteLine(i);
            }

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
