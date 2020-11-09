using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly List<countries> DataSet = new List<countries>();
        private static double _rabat;
        private static double _skat;

        private static void Main(string[] args)
        {
            //Tager imod input for antal af items
            Console.WriteLine("Indtast antal items");
            var antal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antalet af items: " + antal);

            //Tager imod input til prisen
            Console.WriteLine("indstant prisen");
            var pris = Convert.ToDouble(Console.ReadLine());

            //Udregner total pris
            var totalPris = antal * pris;
            Console.WriteLine("Total prisen er: " + totalPris);

            //Udregner rabat
            udregnRabat(totalPris);
            var udregnetRabat = totalPris * _rabat;
            Console.WriteLine("Rabat = " + udregnetRabat);

            //Udregner endelig pris
            var endeligPris = totalPris - udregnetRabat;
            Console.WriteLine("Endelig pris: " + endeligPris);

            //Bruger angiver stat
            InitList();
            Console.WriteLine("Indtast din stat fra følgende valgmuligheder: ");
            Console.WriteLine("UT, NV, TX, AL, CA");
            var stat = Convert.ToString(Console.ReadLine());

            //Udregner skat
            UdregnSkat(stat);


        }
        private static void InitList()
        {
            DataSet.Add(new countries("UT", 6.85));
            DataSet.Add(new countries("NV", 8.00));
            DataSet.Add(new countries("TX", 6.25));
            DataSet.Add(new countries("AL", 4.00));
            DataSet.Add(new countries("CA", 8.25));
        }
        private static void udregnRabat(double totalPris)
        {
            if (totalPris <= 1000)
            {
                _rabat = 0.3;
            }
            if (totalPris >= 5000 & totalPris < 7000)
            {
                _rabat = 0.5;
            }
            if (totalPris >= 7000 & totalPris < 10000)
            {
                _rabat = 0.7;
            }
            if (totalPris >= 10000 & totalPris < 50000)
            {
                _rabat = 0.10;
            }
            if (totalPris >= 50000)
            {
                _rabat = 0.15;
            }
        }
        private static void UdregnSkat(String stat)
        {
            var countriesObject = DataSet[0];
            if (stat == countriesObject.getCountryCode())
            { 
                _skat = 6.85;
            }
            Console.WriteLine("Din skatte procent er: " + _skat);
        }
    }
}
