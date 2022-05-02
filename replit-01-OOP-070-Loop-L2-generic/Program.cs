using System;

namespace replit_01_OOP_070_Loop_L2_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 9, 16, 25 };
            Loop<int> l = new Loop<int>(nums);

            Console.WriteLine(l.Current); //vypíše 1

            l.Right();
            Console.WriteLine(l.Current); //vypíše 4

            l.Right();
            l.Right();
            Console.WriteLine(l.Current); //vypíše 16

            l.Right();
            l.Right();
            Console.WriteLine(l.Current); //vypíše 1


            l.Left();
            Console.WriteLine(l.Current); //vypíše 25

            l.Insert(-5);
            l.Right();
            Console.WriteLine(l.Current); //vypíše -5
        }
    }
}
