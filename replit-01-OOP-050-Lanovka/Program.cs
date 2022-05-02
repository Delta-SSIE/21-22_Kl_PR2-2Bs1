using System;

namespace replit_01_OOP_050_Lanovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Clovek franta = new Clovek("František", 65);
            Clovek lojza = new Clovek("Alois", 94);
            Clovek mila = new Clovek("Milena", 54);
            Clovek anezka = new Clovek("Anežka", 67);

            Lanovka l = new Lanovka(220, 5);


            Clovek tmp;

            tmp = l.Vystup();
            if (tmp != null)
                Console.WriteLine(tmp.Jmeno);
            else
                Console.WriteLine("xxx");

            l.Nastup(franta);
            l.Jed();

            l.Nastup(lojza);
            l.Jed();


            l.Jed();

            Console.WriteLine(  l.Nastup(mila) );
            l.Jed();

            Console.WriteLine(l.Zatizeni);

            tmp = l.Vystup();
            if (tmp != null)
                Console.WriteLine(tmp.Jmeno);
            else
                Console.WriteLine("xxx");

            l.Jed();


        }
    }
}
