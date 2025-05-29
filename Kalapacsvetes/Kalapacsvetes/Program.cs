using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Kalapacsvetes
{
    class Sportolo
    {
        public string Helyezes { get; set; }
        public double Eredmeny { get; set; }
        public string Nev { get; set; }
        public string OrszagKod { get; set; }
        public string Helyszin { get; set; }
        public string[] Datum { get; set; }
        public string Ev { get; set; }
        public string teljesEv { get; set; }

        public Sportolo(string sor)
        {
            string[] adatok = sor.Split(';');
            Helyezes = adatok[0];
            Eredmeny = double.Parse(adatok[1]);
            Nev = adatok[2];
            OrszagKod = adatok[3];
            Helyszin = adatok[4];
            Datum = adatok[5].Split('.');
            teljesEv = adatok[5];
            Ev = Datum[0];
        }
    }
    internal class Program
    {
        static List<Sportolo> lista = new List<Sportolo>();
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("kalapacsvetes.txt"))
            {
                string elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    lista.Add(new Sportolo(sr.ReadLine()));
                }
            }

            f4();
            f5();
            f6();
            f7();
            f8();
            Console.ReadLine();
        }
        static void f4()
        {
            Console.WriteLine($"4. feladat: {lista.Count} dobás eredménye található.");
        }
        static void f5()
        {
            int magyarSportolok = 0;
            double magyarOsszeg = 0;

            foreach (Sportolo item in lista)
            {
                if (item.OrszagKod == "HUN")
                {
                    magyarSportolok++;
                    magyarOsszeg += item.Eredmeny;

                }
            }
            double magyarAtlag = Math.Round(magyarOsszeg / magyarSportolok, 2);
            Console.WriteLine($"5. Feladat: A magyar sportolók átlagosan {magyarAtlag} métert dobtak!");
        }
        static void f6()
        {
            Console.Write("6.feladat: Adjon meg egy évszámot:");
            string ev = Console.ReadLine();

            int dobasDarab = 0;
            List<string> dobok = new List<string>();
            foreach (Sportolo item in lista)
            {
                if (ev == item.Ev)
                {
                    dobasDarab++;
                    dobok.Add(item.Nev);
                }
            }
            if (dobasDarab == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("\t Egy dobás sem került be ebben az évben.");
            }
            else
            {
                Console.WriteLine($"\t{dobasDarab} darab dobás került be ebben az évben:");
                foreach (String item in dobok)
                {
                    Console.WriteLine($"\t\t{item}");
                }
            }
        }
        static void f7()
        { 
            Dictionary<string, int> statisztika = new Dictionary<string, int>();
            foreach (Sportolo item in lista)
            {
                if (statisztika.ContainsKey(item.OrszagKod))
                {
                    statisztika[item.OrszagKod]++;
                }
                else 
                {
                    statisztika.Add(item.OrszagKod, 1);
                }
            }
            Console.WriteLine("Statisztika:");
            Console.WriteLine("");
            foreach (var item in statisztika)
            {
                Console.WriteLine($"{item.Key} - {item.Value} dobás ");
            }
        }
        static void f8()
        {
            using (StreamWriter sw = new StreamWriter("magyarok.txt"))
            {
                foreach (Sportolo item in lista)
                {
                    if (item.OrszagKod == "HUN")
                    {
                        sw.WriteLine($"{item.Helyezes};{item.Eredmeny};{item.Nev};{item.OrszagKod};{item.Helyszin};{item.teljesEv}");
                    }
                }
            }
        }
    }
}