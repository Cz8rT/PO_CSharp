using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            static int FibonacciRec(int n){
            	if(n == 0) return (n);
                if(n == 1) return (n);
            	return (FibonacciRec(n-1) + FibonacciRec(n-2));  // Fibonacci
            }

            Console.WriteLine(FibonacciRec(0));
            Console.WriteLine(FibonacciRec(1));
            Console.WriteLine(FibonacciRec(2));
            Console.WriteLine(FibonacciRec(5));
            Console.WriteLine(FibonacciRec(7));
            Console.WriteLine(FibonacciRec(8));

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
