using System;

namespace _02_OOP_09_Ucet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet u = new Ucet();
            u.Uloz(100);
            u.Vyber(50);
            Console.WriteLine(u);
            u.Vyber(100);
            Console.WriteLine(u);
            u.Urokuj(10);
            Console.WriteLine(u);
        }
    }
}
