using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_02_Ctverec_a_obdelnik
{
    class Obdelnik
    {
        public double StranaA { get; private set; }
        public double StranaB { get; private set; }

        public Obdelnik(double stranaA, double stranaB)
        {
            StranaA = stranaA;
            StranaB = stranaB;
        }

        public double Obvod()
        {
            return 2 * (StranaA + StranaB);
        }
        public double Obsah()
        {
            return StranaA * StranaB;
        }

    }
}
