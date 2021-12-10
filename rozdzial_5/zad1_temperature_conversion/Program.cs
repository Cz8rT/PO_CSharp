using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static double fah_to_cel(double tempC){
            double tempF = (tempC - 32)/1.8;
            return tempF;
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
            double user_temp = double.Parse(Console.ReadLine());
            string temp = fah_to_cel(user_temp).ToString("0.0");
            Console.Write("Temperatura w stopniach Celsjusza: {0}", temp);
            Console.WriteLine();

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}