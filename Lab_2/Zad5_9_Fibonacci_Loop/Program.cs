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
                int a = 0;
                int b = 1;
                for(int i = 1; i < n; i++){
                    b += a;
                    a = b - a;
                }
            	return b;  // Fibonacci loop
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
