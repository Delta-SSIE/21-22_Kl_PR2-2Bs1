using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_07_Kruznice_II
{
    class Kruznice
    {

        private double _polomer;
        public double Polomer 
        { 
            set
            {
                if (value >= 0) //když je OK
                    _polomer = value;
                else
                    throw new ArgumentOutOfRangeException("Negative diameter");
            }
            get
            {
                return _polomer;
            }
        }

        public Kruznice()
        {
            Polomer = 0;
        }

        public Kruznice(double polomer)
        {
            Polomer = polomer;
        }


        public double Plocha
        {
            get
            {
                return Math.PI * _polomer * _polomer;
            }            
        }
    }
}
