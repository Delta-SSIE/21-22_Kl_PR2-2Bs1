using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_08_Bod
{
    class Obdelnik
    {
        public double Vyska { get; private set; }
        public double Sirka { get; private set; }
        public Bod LevyHorniRoh { get; private set; }
        public Bod PravyHorniRoh
        {
            get
            {
                return new Bod(LevyHorniRoh.X + Sirka, LevyHorniRoh.Y);
            }
        }
        public Bod LevyDolniRoh
        {
            get
            {
                return new Bod(LevyHorniRoh.X, LevyHorniRoh.Y - Vyska);
            }
        }
        public Bod PravyDolniRoh
        {
            get
            {
                return new Bod(LevyHorniRoh.X + Sirka, LevyHorniRoh.Y - Vyska); 
            }
        }


        public Obdelnik(double vyska, double sirka, Bod levyHorni)
        {
            Vyska = vyska;
            Sirka = sirka;
            LevyHorniRoh = levyHorni;
        }

        public bool Obsahuje(Bod bod)
        {
            if (
                   bod.X >= LevyHorniRoh.X
                && bod.Y <= LevyHorniRoh.Y
                && bod.X <= PravyDolniRoh.X
                && bod.Y >= PravyDolniRoh.Y
            )
                return true;
            else
                return false;
        }

    }
}
