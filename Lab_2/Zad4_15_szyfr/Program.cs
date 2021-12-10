using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            static string incrypt(string tekst){
            	string tekstZaszyfrowany = String.Empty;
                string szyfr = "GADERYPOLUKI";
                for(int i = 0; i < tekst.Length; i++){

                    int position = szyfr.IndexOf(tekst[i]);

                    if(position == -1){
                        tekstZaszyfrowany += tekst[i];
                        continue;
                    }

                    if(position % 2 == 0)
                        tekstZaszyfrowany += szyfr[position+1];

                    if(position % 2 != 0)
                        tekstZaszyfrowany += szyfr[position-1];

                }
            	return tekstZaszyfrowany;
            }

            Console.Write("DRZEWO zaszyfrowane: ");
            Console.WriteLine(incrypt("DRZEWO"));
            Console.Write("LUSTRO zaszyfrowane: ");
            Console.WriteLine(incrypt("LUSTRO"));

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }
}
