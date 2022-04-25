using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_04_Firma_zamestnanci
{
    class Firma
    {
        private List<Zamestnanec> _zamestanci = new List<Zamestnanec>();

        public void Zamestnej(Zamestnanec z)
        {
            //if (_zamestanci.Contains(z))
            //    return;
            foreach (Zamestnanec zamestnanec in _zamestanci)
            {
                if (zamestnanec == z)
                    return;
            }

            _zamestanci.Add(z);
        }
        public void Propust(Zamestnanec z)
        {
            _zamestanci.Remove(z);
        }
        public void Vyplata()
        {
            int celkem = 0;
            foreach (Zamestnanec z in _zamestanci)
            {
                celkem += z.Mzda();
                Console.WriteLine($"{z.Prijmeni}, {z.Jmeno}: {z.Mzda()} Kč");
            }
            Console.WriteLine("-------");
            Console.WriteLine($"Celkem: {celkem} Kč");
        }
    }
}
