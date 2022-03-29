using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_01_Zoo
{
    class Velryba : Savec
    {
        public Velryba(string jmeno) : base(jmeno)
        {
        }

        public void Plav()
        {
            Console.WriteLine("Šplouchy šplouch");
        }

        public override void OzviSe()
        {
            Console.WriteLine("Huí huí huí");
        }
    }
}
