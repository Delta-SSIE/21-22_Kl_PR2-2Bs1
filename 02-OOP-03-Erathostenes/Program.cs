using System;
using System.Collections.Generic;

namespace _02_OOP_03_Erathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10000;
            int[] primes = Primes(max);

            Console.WriteLine(string.Join(", ", primes));

        }

        static int[] Primes(int max)
        {
            // připravím tabulku všech čísel

            bool[] numbers = new bool[max + 1];

            // škrtnu 0,1
            numbers[0] = false;
            numbers[1] = false;

            for (int i = 2; i < max + 1; i++)
            {
                numbers[i] = true; //označím všechna jako potenciální prvočísla
            }

            // pokračuju až do odmocniny z max po jedné
            int limit = (int)Math.Sqrt(max);
            for (int i = 0; i <= limit; i++)
            {
                // když je škrtnuto, jdu dál
                if (!numbers[i]) //if (numbers[i] == false)
                {
                    continue;
                }

                // když není škrtnuto, je to prvočíslo, škrtnu násobky
                else
                {
                    for (int j = 2 * i; j < max + 1; j += i)
                    {
                        numbers[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            // vypíšu vše neškrtnuté
            for (int i = 0; i < max + 1; i++)
            {
                if (numbers[i])
                    primes.Add(i);
            }

            return primes.ToArray();
        }
    }
}
