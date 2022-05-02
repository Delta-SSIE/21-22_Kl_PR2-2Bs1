using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_030_Archiv
{
    class Archiv
    {
        private int _pocetPolic;
        private int _kapacita;

        public Archiv(int pocetPolic, int kapacita)
        {
            _pocetPolic = pocetPolic;
            _kapacita = kapacita;
            Pocet = 0;
        }

        public int Pocet { get; private set; }

        public void Uloz(int kolik)
        {
            if (kolik <= 0 )
            {
                throw new ArgumentOutOfRangeException();
            }
            Pocet += kolik;
        }

        public void Reset()
        {
            Pocet = 0;
        }

        public int Skrin
        {
            get
            {
                return Pocet / (_kapacita * _pocetPolic) + 1;
            }
        }

        public int Police
        {
            get
            {
                int vJedneSkrini = _kapacita * _pocetPolic;
                int vPosledniSkrini = Pocet % vJedneSkrini;
                return vPosledniSkrini / _kapacita + 1;
            }
        }

        public int Pozice
        {
            get
            {
                return Pocet % _kapacita + 1;
            }
        }
    }
}
