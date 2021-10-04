using System;

namespace _01_OOP_Enum_Demo
{
    enum Obdobi:byte { Jaro = 1, Leto, Podzim = 5, Zima }
    class Program
    {

        static void Main(string[] args)
        {
            //Obdobi chladne = Obdobi.Jaro;
            //Console.WriteLine(chladne);

            //chladne++;
            //Console.WriteLine(chladne);

            //chladne++;
            //chladne++;
            //Console.WriteLine(chladne);
            //chladne++;
            //Console.WriteLine(chladne);

            //Obdobi horke = (Obdobi)1;
            //Console.WriteLine(horke);

            Obdobi barevne = Obdobi.Podzim;
            Console.WriteLine((int)barevne);

            Console.ReadKey();

        }
    }
}
