using System;

namespace _02_OOP_06_Kruznice_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Kruznice k = new Kruznice();
            //    k.SetPolomer(-1);
            //    Console.WriteLine($"Obsah kružnice o poloměru {k.GetPolomer()} je {k.Plocha()}");
            //}
            //catch
            //{
            //    Console.WriteLine("Neplatná hodnota poloměru");
            //}

            try
            {
                Kruznice k = new Kruznice();
                //k.SetPolomer(1);
                Console.WriteLine($"Obsah kružnice o poloměru {k.GetPolomer()} je {k.Plocha()}");
            }
            catch
            {
                Console.WriteLine("Neplatná hodnota poloměru");
            }

        }
    }
}
