using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Karty
{
    class Karta
    {
        public VyskaKarty Vyska { get; private set; }
        public BarvaKarty Barva { get; private set; }

        public Karta(VyskaKarty vyska, BarvaKarty barva)
        {
            Vyska = vyska;
            Barva = barva;
        }

        public static bool operator >(Karta kartaL, Karta kartaP)
        {
            return kartaL.Vyska > kartaP.Vyska;
        }
        public static bool operator <(Karta kartaL, Karta kartaP)
        {
            return kartaL.Vyska < kartaP.Vyska;
        }

        public override bool Equals(object obj)
        {
            return obj is Karta karta &&
                   Vyska == karta.Vyska &&
                   Barva == karta.Barva;
        }

        public override string ToString()
        {
            return $"Karta ({Vyska}, {Barva})";
        }
    }
}
