using System;

namespace Iface_dp
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorka babetta = new Motorka(1, 45, 22);
            IPojizdny vehikl1 = babetta;
            Console.WriteLine(vehikl1.PocetKol);

            Letadlo concorde = new Letadlo(80, 1200, 5000);
            IMotorovy letadlo = concorde;
            letadlo.Napln();

            Kocarek k = new Kocarek();
            IPojizdny vehikl2 = k;
            

        }
    }
    interface IPojizdny
    {
        public int PocetKol { get; }
    }
    enum TypMotoru
    {
        Diesel,
        Benzin,
        Elektricky,
        Vodikovy
    }
    interface IMotorovy
    {
        public TypMotoru Motor { get; }
        public int Vykon { get; }
        public void Napln();
    }
    class Kocarek : IPojizdny
    {
        public int PocetKol
        {
            get
            {
                return 4;
            }
        }
    }
    abstract class DopravniProstredek
    {
        public int PocetPasazeru { get; private set; }
        public double MaxRychlost { get; private set; }

        protected DopravniProstredek(int pocetPasazeru, double maxRychlost)
        {
            PocetPasazeru = pocetPasazeru;
            MaxRychlost = maxRychlost;
        }
    }
    class Letadlo : DopravniProstredek, IMotorovy
    {
        public int Vykon
        {
            get; private set;
        }
        public TypMotoru Motor { 
            get
            {
                return TypMotoru.Benzin;
            }
                
        }

        public Letadlo(int pocetPasazeru, double maxRychlost, int vykon) : base(pocetPasazeru, maxRychlost)
        {
            Vykon = vykon;
        }

        public void Napln()
        {
            Console.WriteLine("tankuju benzín");
        }

    }

    class Motorka : DopravniProstredek, IMotorovy, IPojizdny
    {
        //public int Pocetkol { get
        //    {
        //        return 2;
        //    }
        //}

        public int PocetKol => 2;

        public int Vykon
        {
            get; private set;
        }
        public TypMotoru Motor
        {
            get
            {
                return TypMotoru.Benzin;
            }

        }
        public Motorka(int pocetPasazeru, double maxRychlost, int vykon) : base(pocetPasazeru, maxRychlost)
        {
            Vykon = vykon;
        }

        public void Napln()
        {
            Console.WriteLine("Zastavuju na benzince");
        }
    }
}
