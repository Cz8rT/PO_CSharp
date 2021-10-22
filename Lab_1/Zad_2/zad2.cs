using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            var machine = System.Environment.MachineName; // Nazwa komputera użytkownika
            float a, b, c;
            double delta;
            Console.WriteLine("Obliczę deltę!");
            Console.Write("Podaj współczynnik a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Podaj współczynnik b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Podaj współczynnik c: ");
            c = float.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4*a*c;
            Console.WriteLine("Delta wynosi: {0:F2}", delta);
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
