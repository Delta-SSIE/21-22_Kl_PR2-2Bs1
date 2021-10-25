using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Karty
{
    class Balicek
    {
        //úložiště karet
        private Queue<Karta> _karty = new Queue<Karta>();

        //generátor náh. čísel
        private Random _rnd = new Random();

        public int PocetKaret 
        { 
            get
            {
                return _karty.Count;
            }
        }

        //Zamichej
        public void Zamichej()
        {
            // vezmu všechny karty v balíčku
            Karta[] tmp = _karty.ToArray();

            for (int i = 0; i < tmp.Length - 1; i++)
            {
                int nahPoradi = _rnd.Next(i, tmp.Length);
                
                Karta vyndej = tmp[nahPoradi];
                tmp[nahPoradi] = tmp[i];
                tmp[i] = vyndej;
            }

            _karty = new Queue<Karta>(tmp);
        }

        public Karta VezmiHorni()
        {
            Karta horni = _karty.Dequeue();
            return horni;
        }

        public void PridejDospod(Karta karta)
        {
            _karty.Enqueue(karta);
        }

        public void Vypis()
        {
            foreach (Karta karta in _karty)
            {
                Console.WriteLine(karta);
            }
        }
    }
}
