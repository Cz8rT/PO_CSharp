using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, max;
            Console.WriteLine("Która liczba jest największa? Sprawdźmy!.");
            Console.Write("Podaj pierwszą liczbę: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            z = int.Parse(Console.ReadLine());
            if (x > y & x > z){
                max = x;
            } else if (y > z){
                max = y;
            } else {
                max = z;
            }
            Console.WriteLine("Największa liczba z podanych to: " + max);

            var machine = System.Environment.MachineName;
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
