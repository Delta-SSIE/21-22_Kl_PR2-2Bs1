using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Karty
{
    class Hra
    {
        private Balicek _hracA;
        private Balicek _hracB;

        public bool JeKonec { 
            get
            {
                //když jednomu dojdou karty
                return _hracA.PocetKaret == 0 || _hracB.PocetKaret == 0; 
            }
        }

        public Hra()
        {

            // vytvoř balíčky pro oba hráče
            _hracA = new Balicek();
            _hracB = new Balicek();

            // vezmi plnou sadu nových karet
            Balicek balicek = Balicek.VytvorNoveKarty();
            balicek.Zamichej();

            // rozdej jim karty
            while (balicek.PocetKaret > 0)
            {
                _hracA.PridejDospod(balicek.VezmiHorni());
                _hracB.PridejDospod(balicek.VezmiHorni());
            }

        }

        public string Kolo()
        {
            // výpis průběhu
            string log = "";

            // o co se hraje?
            Balicek kartyKola = new Balicek();

            // říká, zda se má hrát dál - karty obou mají stejnou váhu
            bool shodaKaret = true;

            //dokud neni nerovnost a je co brat
            while (shodaKaret &&!JeKonec) {
                // oba vezmou horní kartu
                Karta kartaA = _hracA.VezmiHorni();
                Karta kartaB = _hracB.VezmiHorni();

                // karty se zapisou do Karet kola
                kartyKola.PridejDospod(kartaA);
                kartyKola.PridejDospod(kartaB);

                // pokud jeden bere, karty kola mu předáme
                if (kartaA > kartaB)
                {
                    log += $"Bere hráč A {kartaA} > {kartaB}.";
                    kartyKola.Zamichej();
                    _hracA.PridejBalicek(kartyKola);
                    shodaKaret = false;
                }
                else if (kartaB > kartaA)
                {
                    log += $"Bere hráč B {kartaA} < {kartaB}.";
                    kartyKola.Zamichej();
                    _hracB.PridejBalicek(kartyKola);
                    shodaKaret = false;
                }
                else
                {
                    log += $"Shoda: {kartaA} = {kartaB}" + System.Environment.NewLine;
                }
            }

            return log;            
        }

        public string Vysledek()
        {
            if (_hracB.PocetKaret == 0)
                return "Vyhrál hráč A";
            else if (_hracA.PocetKaret == 0)
                return "Vyhrál hráč B";
            else
                return "Hra ještě neskončila";
        }
    }
}
