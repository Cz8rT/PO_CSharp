using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lab2
{
    class Program
    {   
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 01, 23);
            Telefon telefon1 = new Telefon();
            telefon1.DodajPolaczenie("123543", 21);
            telefon1.DodajSms("3265");
            telefon1.DodajInternet(65445);
            telefon1.ZapiszBiling();

            var machine = System.Environment.MachineName;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dziękuję " + machine + ". Naciśnij przycisk, by zakończyć.");
            Console.ReadKey();
        }
    }

    public abstract class RodzajUslugi                       // Deklaracja klasy
    {
        protected DateTime czas;
        protected double cena;
        public RodzajUslugi(DateTime aCzas)                 // konstruktor
        {
            this.czas = aCzas;
        }

        public abstract void obliczCene();

    }

    class Polacznie : RodzajUslugi               // Deklaracja klasy
    {
        private string numer;
        private int czasP;

        public Polacznie(DateTime aCzas, string aNumer, int aCzasP) : base (aCzas){
            czas = aCzas;
            numer = aNumer;
            czasP = aCzasP;
            obliczCene();
        }

        public override void obliczCene(){
            cena = czasP * 0.38;
        }

        public override string ToString(){                 // Przesłanianie metody toString()
            return "Połączenie: numer " + numer + 
                    " , data i godzina rozmowy: " 
                    + czas + " , długość trwania: " + czasP + 
                    " , łączny koszt: " + cena;
        }

    }

    class Sms : RodzajUslugi
    {
        string numer;

        public Sms(DateTime aCzas, string aNumer): base (aCzas){
            czas = aCzas;
            numer = aNumer;
            obliczCene();

        }
        public override void obliczCene(){
            cena = 0.18;
        }

        public override string ToString(){                  // Przesłanianie metody toString()
            return "Sms: numer " + numer + 
                    " , data i godzina smsa: " 
                    + czas + " , łączny koszt: " + cena;
        }
    }

    class Internet : RodzajUslugi
    {
        private int iloscMB;

        public Internet(DateTime aCzas, int aIlosc): base (aCzas){
            czas = aCzas;
            iloscMB = aIlosc;
            obliczCene();

        }
        public override void obliczCene(){
            cena = iloscMB / 754;
            cena = Math.Round(cena, 2);
        }

        public override string ToString(){                  // Przesłanianie metody toString()
            return "Internet: data i godzina internetu: " 
                    + czas + " , łączna ilość MB: " + iloscMB 
                    + " , łączny koszt: " + cena;
        }
    }

    public interface IBiling{                               // Interfejsy
        void ZapiszBiling();
    }

    public interface IDodaj{
        void DodajPolaczenie(string numer, int czasP);
        void DodajSms(string numer);
        void DodajInternet(int iloscMB);
    }

    class Telefon : IBiling, IDodaj
    {
        private List<RodzajUslugi> biling = new List<RodzajUslugi>();

        public void DodajPolaczenie(string numer, int czasP){
           biling.Add(new Polacznie(DateTime.Now, numer, czasP));
        } 
        public void DodajSms(string numer){
            biling.Add(new Sms(DateTime.Now, numer));
        } 

        public void DodajInternet(int iloscMB){
            biling.Add(new Internet(DateTime.Now, iloscMB));
        } 

        public override string ToString(){                   // Przesłanianie metody toString()
            string tekst = "Wartości bilingów:\n";
            try{
                for(int i = 0; i < biling.Count; i++){
                tekst += biling[i];
                tekst += "\n";
                }

            } 
            catch {
                tekst += "Brak billingów!";
            }
            return tekst;
        }

        public void ZapiszBiling(){
            string filepath = "biling.txt";                    // Zapisywanie pliku tekstowego (using System.IO, using.System.Linq)
            try    
            {    
                // Sprawdzanie czy plik istnieje i kasowanie go jeśli istnieje     
                if (File.Exists(filepath))    
                {    
                    File.Delete(filepath);    
                }                                    
                // Tworzenie pliku     
                
                System.IO.File.WriteAllText(filepath, ToString());
                
            }    
            catch (Exception Ex)    
            {    
                Console.WriteLine(Ex.ToString());    
            }

        }
    }
}