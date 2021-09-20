using System;

namespace _01_Uvod_02_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadej celé číslo: ");
            //string input = Console.ReadLine();

            //int cislo;
            //if (int.TryParse(input, out cislo))
            //{
            //    Console.WriteLine($"Číslo je {cislo}");
            //}
            //else
            //{
            //    Console.WriteLine("To nejde převést");
            //}


            Console.WriteLine("Zadej celé číslo: ");
            string input = Console.ReadLine();
            int cislo;
            while (!int.TryParse(input, out cislo))
            {
                Console.WriteLine("Zadej celé číslo, truhlíku! Zkus to znova");
                input = Console.ReadLine();
            }
        }
    }
}
