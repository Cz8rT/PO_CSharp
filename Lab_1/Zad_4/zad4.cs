using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x = 100;
            Console.WriteLine(++x * 2);
            /*
            Konkatenacja poprzedza działanie mnożenia
            Wynik programu to 202
            */
            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
