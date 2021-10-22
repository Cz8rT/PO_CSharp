using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
            int c = Int32.Parse(Console.ReadLine());
            double f = 32 + (9/5.0*c);
            Console.WriteLine("Temperatura w stopniach Fahrenheita: {0:F1}°", f);
            var machine = System.Environment.MachineName;
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
