using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x, y = 4;
            x = (y -= 2);
            // x = 2, y = 2;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            x = y++;
            // x = 2, y = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            x = y--;
            // x = 3, y = 2;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
