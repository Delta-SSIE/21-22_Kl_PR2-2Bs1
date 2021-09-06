using System;

namespace _01_Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int cislo = 13;

            string stav = cislo > 10 ? "velké" : "malé";

            //if (cislo > 10)
            //{
            //    stav = "velke";
            //}
            //else
            //{
            //    stav = "malé";
            //}

            string stav2 =    cislo < 3 ? "prťavé" 
                            : cislo < 5 ? "malé"
                            : cislo  < 10 ? "tak akorát"
                            : "velké";

            Console.WriteLine("Číslo je " + cislo + ".");
            Console.WriteLine("Číslo je {0}.", cislo);
            Console.WriteLine($"Číslo je {cislo}.");






        }
    }
}
