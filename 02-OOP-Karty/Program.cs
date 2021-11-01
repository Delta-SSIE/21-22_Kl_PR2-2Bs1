using System;

namespace _02_OOP_Karty
{
    class Program
    {
        static void Main(string[] args)
        {

            Hra hra = new Hra();

            while(!hra.JeKonec)
            {
                System.Threading.Thread.Sleep(250);
                string logKola = hra.Kolo();
                Console.WriteLine(logKola);
            }

            Console.WriteLine(hra.Vysledek());

        }

        private static void Porovnani(Karta karta1, Karta karta2)
        {
            if (karta1 > karta2)
                Console.WriteLine($"{karta1} bere {karta2}");
            else if (karta1 < karta2)
                Console.WriteLine($"{karta1} podlehne {karta2}");
            else
                Console.WriteLine($"{karta1} je stejné hodnoty jako {karta2}");
        }

        static void ArchivMain()
        {
            Karta SrdcovaSedma = new Karta(VyskaKarty.Sedmicka, BarvaKarty.Srdce);
            Karta ZaludovejFilek = new Karta(VyskaKarty.Filek, BarvaKarty.Zaludy);

            //Console.WriteLine(SrdcovaSedma);

            //Porovnani(SrdcovaSedma, ZaludovejFilek);
            //Porovnani(
            //    SrdcovaSedma,
            //    new Karta(VyskaKarty.Sedmicka, BarvaKarty.Zaludy)
            //);

            //vytvořit balíček karet

            Karta[] balicek = new Karta[32];
            for (int b = 0; b < 4; b++)
            {
                for (int v = 0; v < 8; v++)
                {
                    //b * 8 + v ... pořadí karty
                    balicek[b * 8 + v] = new Karta((VyskaKarty)v, (BarvaKarty)b); // přetypování z čísla na enumeraci
                }
            }

            foreach (Karta karta in balicek)
            {
                Console.WriteLine(karta);
            }



            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Po stisku klávesy ENTER ti ukážu náhodnou kartu");
                Console.ReadLine();
                int nahodnyIndex = random.Next(balicek.Length);
                Console.WriteLine(balicek[nahodnyIndex]);
            }
        }
    }
}
