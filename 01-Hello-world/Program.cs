using System;

namespace _01_Uvod_00_Opakovani_syntaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int cislo = 13;

            //string stav = cislo > 10 ? "velké" : "malé";

            //if (cislo > 10)
            //{
            //    stav = "velke";
            //}
            //else
            //{
            //    stav = "malé";
            //}

            //string stav2 =    cislo < 3 ? "prťavé" 
            //                : cislo < 5 ? "malé"
            //                : cislo  < 10 ? "tak akorát"
            //                : "velké";

            //Console.WriteLine("Číslo je " + cislo + ".");
            //Console.WriteLine("Číslo je {0}.", cislo);
            //Console.WriteLine($"Číslo je {cislo}.");

            //int i = 20;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 20);

            //int cislo;
            //bool poprve = true;
            //do
            //{
            //    if (poprve)
            //    {
            //        poprve = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Chyba, zkus to znovu");
            //    }

            //    Console.WriteLine("Zadej číslo mezi 1 a 10");

            //    string odpoved = Console.ReadLine();
            //    cislo = int.Parse(odpoved);
            //}
            //while (cislo > 10 || cislo < 1);
            //Console.WriteLine($"Zadal jsi {cislo}.");


            //for (int cislo = 1; cislo < 20; cislo++)
            //{
            //    if (cislo % 8 == 0)
            //        continue; 

            //    Console.WriteLine(cislo);
            //}
            int a = 10;
            int b = 15;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
}
