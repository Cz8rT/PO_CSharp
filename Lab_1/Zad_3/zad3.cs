using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            var machine = System.Environment.MachineName; // Nazwa komputera użytkownika
            int masa, wzrost;
            double bmi;
            Console.WriteLine("Witaj " + machine + ".");
            Console.Write("Podaj swoją wagę w kilogramach: ");
            masa = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj swój wzrost w centymetrach: ");
            wzrost = Int32.Parse(Console.ReadLine());

            bmi = 1.0*masa/wzrost;
            Console.WriteLine("Twój współczynnik BMI: {0:F2}", bmi);
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
