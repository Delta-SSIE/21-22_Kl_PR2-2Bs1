using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_09_Ucet
{
    class Ucet
    {
        public double Stav { get; private set; }

        public void Uloz(double castka)
        {
            if (castka < 0)
            {
                throw new ArgumentOutOfRangeException("Nelze ukládat zápornou částku.");
            }
            Stav += castka;
        }

        /// <summary>
        /// Vybere z účtu požadovanou částku nebo vráti false
        /// </summary>
        /// <param name="castka"></param>
        /// <returns>true pro úspěch, false v případě nedostatečné jistiny</returns>
        public bool Vyber(double castka)
        {
            if (Stav >= castka)
            {
                Stav -= castka;
                return true;
            }
            else 
            { 
                return false;
            }

        }

        public void Urokuj(double urokovaMira)
        {
            Stav *= 1 + urokovaMira / 100;
        }

        public override string ToString()
        {
            return $"Stav účtu: {Stav} USD";
        }
    }
}
