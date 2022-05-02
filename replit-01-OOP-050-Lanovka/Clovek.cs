using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_050_Lanovka
{
    class Clovek
    {
        public string Jmeno { get; private set; }
        public double Hmotnost { get; private set; }

        public Clovek (string jmeno, double hmotnost)
        {
            Jmeno = jmeno;

            if (hmotnost > 0)
                Hmotnost = hmotnost;
            else
                throw new ArgumentOutOfRangeException();
        } 
    }
}
