using System;


namespace _04_OOP_Dedicnost_03_Pocitadlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Counter
    {
        public int Count { get; protected set; }
        public virtual void Next()
        {
            Count++;
        }
        public virtual void Reset()
        {
            Count = 0;
        }
    }

    class StepCounter : Counter
    {
        private int step;

        public StepCounter(int step)
        {
            this.step = step;
        }
        public override void Next()
        {
            Count += step;
        }
    }
    class DownCounter : StepCounter
    {
        private int initialValue;
        public bool IsFinished
        {
            get
            {
                return Count <= 0;
            }
        }
        //public bool IsFinished => Count <= 0;
        public DownCounter(int step, int initialValue) : base(-step)
        {
            this.initialValue = initialValue;
            Reset();
        }
        public override void Reset()
        {
            Count = initialValue;
        }
    }
}
