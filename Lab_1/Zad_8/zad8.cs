using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            // x = True, y = 1, z = 2
            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
