using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            /*
            x = (y * 2) * x
            Wynik programu to 12
            */
            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
