using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // // a)
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            // Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // // Wynik=False x=2 y=4 z=2

            // // b)
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            // Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // // Wynik=False x=2 y=5 z=2

            // // c)
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            // Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // // Wynik=False x=2 y=5 z=1

            // // d)
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            // Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // // Wynik=True x=1 y=3 z=4

            // // e)
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            // Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // // Wynik=True x=1 y=4 z=4

            // f)
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Wynik=True x=1 y=4 z=5

            Console.WriteLine("Naciśnij przycisk, by zakończyć program.");
            Console.ReadKey();
        }
    }
}
