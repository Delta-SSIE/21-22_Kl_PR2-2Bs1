using System;

namespace _02_OOP_07_Kruznice_II
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice();
                k.Polomer = -1;
                Console.WriteLine($"Obsah kružnice o poloměru {k.Polomer} je {k.Plocha}");
                //k.Plocha = 6;
            }
            catch
            {
                Console.WriteLine("Neplatná hodnota poloměru");
            }

            try
            {
                Kruznice k = new Kruznice(6);
                Console.WriteLine($"Obsah kružnice o poloměru {k.Polomer} je {k.Plocha}");
            }
            catch
            {
                Console.WriteLine("Neplatná hodnota poloměru");
            }
        }
    }
}
