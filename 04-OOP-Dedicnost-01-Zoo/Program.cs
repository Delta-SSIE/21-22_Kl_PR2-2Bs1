using System;

namespace _04_OOP_Dedicnost_01_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kun ferda = new Kun("Ferda");
            ferda.Cvalej();
            ferda.SajMleko(); //lze, kůň je savec

            Velryba mobyDick = new Velryba("Moby Dick");
            mobyDick.SajMleko();
            mobyDick.Plav();
            //mobyDick.Cvalej(); nejde, velryba není kůň

            Savec blesk = new Kun("Blesk");
            blesk.Dychej(); //nelze tu použít metody koně, proměnná jen deklarovaná jen jako savec
            Kun bleskJinak =(Kun) blesk;
            //Velryba chimera = (Velryba)blesk; //kůn není velryba, runtime chyba

            Console.WriteLine();
            Console.WriteLine();

            //Savec hybrid = new Savec(); //nelze, je abstraktní - je to jen kostra, ale nedodělaná

            Savec[] zoo = new Savec[3];
            zoo[0] = ferda;
            zoo[1] = mobyDick;
            zoo[2] = blesk;

            //zoo se jde krmit
            foreach (Savec zvire in zoo)
            {
                //zvire.Dychej();
                //zvire.SajMleko();
                zvire.OzviSe();
            }

        }
    }
}
