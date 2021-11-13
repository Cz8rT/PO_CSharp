using System;
using System.Globalization;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kwota;
            double srednia;

            Console.WriteLine("Podaj swoją średnią ocen: ");
            Double.TryParse(Console.ReadLine().Replace(',', '.'), 
                NumberStyles.Any, CultureInfo.InvariantCulture, out srednia);

            if (srednia < 4.00)
                kwota = "0,00zł";
            else if (srednia < 4.80)
                kwota = "350,00zł";
            else
                kwota = "550,00zł";
            
            Console.WriteLine("Przysługujące stypendium: {0}", kwota);
            
            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
