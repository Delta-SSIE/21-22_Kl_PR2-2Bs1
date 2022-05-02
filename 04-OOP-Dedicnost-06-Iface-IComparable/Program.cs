using System;

namespace _04_OOP_Dedicnost_06_Iface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Strom[] sad = new Strom[]
            {
                new Strom() {Druh = "Jabloň", Vyska = 5.5},
                new Strom() {Druh = "Smrk", Vyska = 12},
                new Strom() {Druh = "Hrušeň", Vyska = 8.2},
                new Strom() {Druh = "Třešeň", Vyska = 3.3},
                new Strom() {Druh = "Švestka", Vyska = 4.1}
            };

            foreach (Strom strom  in sad)
            {
                Console.WriteLine($"{strom.Druh}: {strom.Vyska}");                
            }

            Array.Sort(sad);

            foreach (Strom strom in sad)
            {
                Console.WriteLine($"{strom.Druh}: {strom.Vyska}");
            }

            
        }
    }

    class Strom : IComparable
    {
        public string Druh { get; set; }
        public double Vyska { get; set; }

        //public int CompareTo(object obj)
        //{
        //    return Vyska.CompareTo(obj);
        //}


        //int IComparable.CompareTo(object obj)
        //{
        //        //převést na strom
        //        Strom druhyStrom = (Strom)obj;

        //        if (this.Vyska < druhyStrom.Vyska)
        //            return -1;
        //        else if (this.Vyska == druhyStrom.Vyska)
        //            return 0;
        //        else
        //            return 1;
        //}


        public int CompareTo(object obj)
        {
            //převést na strom
            Strom druhyStrom = (Strom)obj;

            if (this.Vyska < druhyStrom.Vyska)
                return -1;
            else if (this.Vyska == druhyStrom.Vyska)
                return 0;
            else
                return 1;
            //return (int)Math.Ceiling(this.Vyska - druhyStrom.Vyska);
        }
    }
}
