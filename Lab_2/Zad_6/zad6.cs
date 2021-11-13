using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, wzrost, bmi;
            Console.WriteLine("Podaj swoją wagę [kg]: ");
            masa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost [cm]: ");
            wzrost = Double.Parse(Console.ReadLine());
            
            bmi = masa/Math.Pow((wzrost/100), 2);

            if (bmi < 18.5)
                Console.WriteLine("Masz niedowagę!");
            else if (bmi >= 25.0)
                Console.WriteLine("Masz nadwagę!");
            else
                 Console.WriteLine("Masz prawidłową wagę.");
            
            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
