using System;
using System.Linq;

namespace _01_Uvod_Obraceni
{
    class Program
    {
        static void Main(string[] args)
        {
            string vstup = "soubory na disku nenalezeny!";
            //string obracene = new String(vstup.Reverse().ToArray());

            string obr = "";
            for (int i = vstup.Length - 1; i >= 0; i++)
            {
                obr += vstup[i];
            }
            "kobyla má malý bok"
        }
    }
}
