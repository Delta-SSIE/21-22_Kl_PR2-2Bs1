using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_040_test_vyrobku
{
    class Tester
    {
        private Vyrobek _vzor;
        public Vyrobek Vzor
        {
            get
            {
                return _vzor;
            }
            set
            {
                if (value == null)
                    throw new  ArgumentNullException();

                _vzor = value;
            }
        }

        private double _tolerance;
        public double Tolerance { 
            get
            {
                return _tolerance;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _tolerance = value;
            }
        }

        public Tester(Vyrobek vzor, double tolerance)
        {
            Vzor = vzor;
            Tolerance = tolerance;
        }

        public bool Vyhovuje(Vyrobek vyrobek)
        {
            double odchylka = vyrobek.Rozmer / Vzor.Rozmer - 1; //např. 0.1 pro vyrobek 11cm a vzor 10 cm

            return Math.Abs(odchylka) < Tolerance / 100;

            //nebo

            double max = Vzor.Rozmer * (1 + Tolerance / 100); // napr. 10 cm * (1 + 5/100) pro 5%
            double min = Vzor.Rozmer * (1 - Tolerance / 100);
            return vyrobek.Rozmer > max && vyrobek.Rozmer < min;
        }
    }
}
