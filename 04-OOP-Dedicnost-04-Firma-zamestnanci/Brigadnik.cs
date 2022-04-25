using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_04_Firma_zamestnanci
{
    class Brigadnik : Zamestnanec
    {
        public int Odpracovano { get; set; }
        public int HodinovaMzda { get; set; }
        public Brigadnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        public override int Mzda()
        {
            return Odpracovano * HodinovaMzda;
        }
    }
}
