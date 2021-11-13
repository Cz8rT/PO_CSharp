using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 10, value1 = 1, value2 = 2, value5 = 5;
            string ciag = "";
            List<string> results = new List<string>(); // Inicjalizacja pustej listy

            for(int z1 = 0; z1 <= sum/value1; z1++)
                for(int z2 = 0; z2 <= sum/value2; z2++)
                    for(int z5 = 0; z5 <= sum/value5; z5++)
                        if(z1 * value1 + z2 * value2 + z5 * value5 == sum) {
                            for(int x = 0; x < z1; x++)
                                ciag += "1zł ";
                            for(int x = 0; x < z2; x++)
                                ciag += "2zł ";
                            for(int x = 0; x < z5; x++)
                                ciag += "5zł ";
                            results.Add(ciag);
                            ciag = "";
                        }
                            
            foreach (string element in results){
                Console.WriteLine(element);
            }

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
