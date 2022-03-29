using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Dedicnost_01_Zoo
{
    abstract class Savec
    {
        protected string Jmeno { get; private set; }
        public Savec (string jmeno)
        {
            Jmeno = jmeno;
        }
        public void Dychej()
        {
            Console.WriteLine("Nádech - výdech ...");
        }

        public void SajMleko()
        {
            Console.WriteLine("Saju...");
        }

        //public virtual void OzviSe()
        //{
        //    Console.WriteLine("Dělám zvuk");
        //}
        public abstract void OzviSe(); //musí mít ozvi se, neříkám jak
    }
}
