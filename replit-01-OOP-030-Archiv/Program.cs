using System;

namespace replit_01_OOP_030_Archiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Archiv sklad = new Archiv(4, 3);

            Console.WriteLine($"Skříň: {sklad.Skrin}, Police: {sklad.Police}, Pozice: {sklad.Pozice}.");
            
            sklad.Uloz(1);
            Console.WriteLine($"Skříň: {sklad.Skrin}, Police: {sklad.Police}, Pozice: {sklad.Pozice}.");

            sklad.Uloz(4);
            Console.WriteLine($"Skříň: {sklad.Skrin}, Police: {sklad.Police}, Pozice: {sklad.Pozice}.");

            sklad.Uloz(100);
            Console.WriteLine($"Skříň: {sklad.Skrin}, Police: {sklad.Police}, Pozice: {sklad.Pozice}.");


        }
    }
}
