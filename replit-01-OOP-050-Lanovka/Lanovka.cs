using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_050_Lanovka
{
    class Lanovka
    {
        public double Nosnost { get; private set; }

        private Clovek[] _sedacky;

        public Lanovka(double nosnost, int delka)
        {
            Nosnost = nosnost;
            _sedacky = new Clovek[delka];
        }

        public double Zatizeni
        {
            get
            {
                double total = 0;
                foreach(Clovek c in _sedacky)
                {
                    if (c != null)
                        total += c.Hmotnost;
                }
                return total;

                //return _sedacky.Select(x => x.Hmotnost).Sum();
            }
        }

        public bool JeVolnoDole
        {
            get
            {
                return _sedacky[0] == null;
            }
        }
        public bool JeVolnoNahore
        {
            get
            {
                return _sedacky[_sedacky.Length - 1] == null;
            }
        }

        public bool Nastup(Clovek clovek)
        {
            if (JeVolnoDole && Nosnost > Zatizeni + clovek.Hmotnost)
            {
                _sedacky[0] = clovek;
                return true;
            }
            else
                return false;
        }

        public Clovek Vystup()
        {
            Clovek clovek = _sedacky[_sedacky.Length - 1];
            _sedacky[_sedacky.Length - 1] = null;
            return clovek;
        }

        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet, nahoře někdo sedí");

            for (int i = _sedacky.Length - 2; i >= 0; i--)
            {
                _sedacky[i + 1] = _sedacky[i];
            }

            _sedacky[0] = null;
        }
    }
}
