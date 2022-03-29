using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_02_Ctverec_a_obdelnik
{
    class Ctverec : Obdelnik
    {
        public Ctverec(double strana) : base(strana, strana)
        {
        }
    }
}
