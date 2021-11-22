using System;

namespace _02_OOP_05_Exception_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int cislo;
            //    try 
            //    { 
            //        cislo = int.Parse(Console.ReadLine());
            //        Console.WriteLine(cislo);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("To není číslo, truhlíku!");
            //    }

            try 
            { 
                double res = SafeDivision();
                Console.WriteLine(res);
            }
            catch (DivideByZeroException e)
            {               
                Console.WriteLine("Invalid operation");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number format");
            }
            catch
            {
                Console.WriteLine("Program panic! Quitting now.");
            }
        }
        public static double SafeDivision()
        {
            double cisloA = int.Parse(Console.ReadLine());
            double cisloB = int.Parse(Console.ReadLine());

            if (cisloB == 0)
            {
                throw new DivideByZeroException("Attempt to divide by zero");
            }

            //throw new Exception();
            return cisloA / cisloB;
        }
    }
}
