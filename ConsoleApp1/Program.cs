using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static List<countries> dataSet = new List<countries>();
        static double rabat;
        static double skat;
        static void Main(string[] args)
        {
            //Tager imod input for antal af items
            Console.WriteLine("Indtast antal items");
            int antal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antalet af items: " + antal);

            //Tager imod input til prisen
            Console.WriteLine("indstant prisen");
            double pris = Convert.ToDouble(Console.ReadLine());

            //Udregner total pris
            double totalPris = antal * pris;
            Console.WriteLine("Total prisen er: " + totalPris);

            //Udregner rabat
            udregnRabat(totalPris);
            double udregnetRabat = totalPris * rabat;
            Console.WriteLine("Rabat = " + udregnetRabat);

            //Udregner endelig pris
            double endeligPris = totalPris - udregnetRabat;
            Console.WriteLine("Endelig pris: " + endeligPris);

            //Bruger angiver stat
            InitList();
            Console.WriteLine("Indtast din stat fra følgende valgmuligheder: ");
            Console.WriteLine("UT, NV, TX, AL, CA");
            string Stat = Convert.ToString(Console.ReadLine());

            //Udregner skat
            udregnSkat(Stat);


        }
        private static void InitList()
        {
            dataSet.Add(new countries("UT", 6.85));
            dataSet.Add(new countries("NV", 8.00));
            dataSet.Add(new countries("TX", 6.25));
            dataSet.Add(new countries("AL", 4.00));
            dataSet.Add(new countries("CA", 8.25));
        }
        private static void udregnRabat(double totalPris)
        {
            if (totalPris <= 1000)
            {
                rabat = 0.3;
            }
            if (totalPris >= 5000 & totalPris < 7000)
            {
                rabat = 0.5;
            }
            if (totalPris >= 7000 & totalPris < 10000)
            {
                rabat = 0.7;
            }
            if (totalPris >= 10000 & totalPris < 50000)
            {
                rabat = 0.10;
            }
            if (totalPris >= 50000)
            {
                rabat = 0.15;
            }
        }
        private static void udregnSkat(String stat)
        {
            countries obj1;
            obj1 = dataSet[0];
            if (stat == obj1.getCountryCode());

            {
                skat = 6.85;
            }
            Console.WriteLine("Din skatte procent er: " + skat);
        }
    }
}
