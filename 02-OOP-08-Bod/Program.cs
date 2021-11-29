using System;

namespace _02_OOP_08_Bod
{
    class Program
    {
        static void Main(string[] args)
        {
            Bod A = new Bod(-2, 3);
            Console.WriteLine("Bod A má souřadnice " + A);

            Bod B = new Bod(2, 6);
            Bod C = new Bod(-2, 3);

            if (A.ShodnyS(B))
            {
                Console.WriteLine("Body A a B jsou shodné");
            }
            else
            {
                Console.WriteLine("Body A a B se liší");
            }

            if (A.ShodnyS(C))
            {
                Console.WriteLine("Body A a C jsou shodné");
            }
            else
            {
                Console.WriteLine("Body A a C se liší");
            }

            Console.WriteLine($"Vzdálenost bodů {A} a {B} je {A.VzdalenostOd(B)}.");

            Obdelnik EFGH = new Obdelnik(4, 3, A);
            Console.WriteLine($"Rohy obdélníka: {EFGH.LevyHorniRoh}, {EFGH.PravyHorniRoh}, {EFGH.PravyDolniRoh}, {EFGH.LevyDolniRoh}");

            Console.WriteLine($"Vzdálenost LD a PH rohu je {EFGH.LevyDolniRoh.VzdalenostOd(EFGH.PravyHorniRoh)}");

            Bod X = new Bod(0, 1);
            Console.WriteLine($"Obdélník {(EFGH.Obsahuje(X) ? "obsahuje" : "neobsahuje")} bod {X}");

            Bod Y = new Bod(-20, 5);
            Console.WriteLine($"Obdélník {(EFGH.Obsahuje(Y) ? "obsahuje" : "neobsahuje")} bod {Y}");
        }
    }
}
