using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj współczynnik 'a': ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik 'b': ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik 'c': ");
            c = Double.Parse(Console.ReadLine());

            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("Równanie ma nieskończenie wiele rozwiązań dla podanych współczynników.");
                    else
                        Console.WriteLine("Równanie nie ma rozwiązań dla podanych współczynników.");
                else
                    Console.WriteLine("Równanie ma jedno rozwiązanie dla podanych współczynników.");
            else 
                if ((Math.Sqrt(b) - 4*a*c) >= 0)
                    Console.WriteLine("Równanie ma dwa rozwiązania dla podanych współczynników.");
                else
                    Console.WriteLine("Równanie nie ma rozwiązań dla podanych współczynników.");

            var machine = System.Environment.MachineName;
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
