using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_04_Firma_zamestnanci
{
    class StalyZamestnanec : Zamestnanec
    {
        private int _mzda;
        public StalyZamestnanec(string jmeno, string prijmeni, int mzda) : base(jmeno, prijmeni)
        {
            _mzda = mzda;
        }
        public override int Mzda()
        {
            return _mzda;
        }
    }
}
