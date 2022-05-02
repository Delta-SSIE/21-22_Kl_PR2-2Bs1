using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_040_test_vyrobku
{
    class Vyrobek
    {
        private double _rozmer;
        public double Rozmer { 
            get
            {
                return _rozmer;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();

                _rozmer = value;
            } 
        
        }
        public Vyrobek(double rozmer)
        {
            Rozmer = rozmer;
        }
    }
}
