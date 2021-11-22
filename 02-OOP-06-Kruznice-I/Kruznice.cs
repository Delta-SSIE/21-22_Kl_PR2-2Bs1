using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_06_Kruznice_I
{
    class Kruznice
    {
        private double _polomer;

        //public double Polomer; //položka
        public void SetPolomer(double hodnota)
        {
            if (hodnota >= 0) //když je OK
                _polomer = hodnota;
            else
                throw new ArgumentOutOfRangeException("Negative diameter");
        }
        public double GetPolomer()
        {
            return _polomer;
        }

        /// <summary>
        /// Creates a new instance of circle
        /// </summary>
        public Kruznice()
        {
            _polomer = 0;
        }
        /// <summary>
        /// Creates a new instance of circle with a given radius
        /// </summary>
        /// <param name="polomer">radius (positive number)</param>
        public Kruznice(double polomer)
        {
            SetPolomer(polomer);
        }


        public double Plocha() //metoda
        {
            return Math.PI * _polomer * _polomer;
        }


    }
}
