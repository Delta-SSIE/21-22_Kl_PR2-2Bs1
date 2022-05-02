using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_020_Tachometr
{
    class Tachometr
    {
        public Tachometr()
        {
            Stav = 0;
        }

        public int Stav { get; private set; }


        public void Ujed( int kilometry)
        {
            if (kilometry < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Stav += kilometry;
        }
    }
}
