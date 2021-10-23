using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = 1.0*osoby/powierzchnia;
            /*
                Działanie dzielenia zmiennnych typu 'int' daje wynik całkowitoliczbowy.
                Należy dokonać konwersji na działanie zmiennoprzecinkowe.
                np. przemnożenie przez liczbę zmiennoprzecinkową lub zmianę typu na float lub double
            */
            Console.WriteLine(gestoscZaludnienia);
            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
