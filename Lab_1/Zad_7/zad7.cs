using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x, y = 5;
            x = ++y * 2;
            // x = 12, y = 6;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            x = y++;
            // x = 6, y = 7;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            x = y--;
            // x = 7, y = 6;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine(++y);
            // y = 7
            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
