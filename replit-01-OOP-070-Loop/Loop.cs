using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_070_Loop
{
    class Loop
    {

        private int[] items;
        private int index;

        public int Current
        {
            get
            {
                return items[index];
            }
        }

        public Loop(int[] items)
        {
            this.items = items;
            index = 0;

        }

        public void Right()
        {
            index++;
            if (index >= items.Length) 
                index = 0;
        }

        public void Right(int count)
        {
            index += count;
            while (index >= items.Length)
                index -= items.Length;
        }

        public void Left()
        {
            index--;
            if (index < 0) 
                index = items.Length - 1;
        }

        public void Left(int count)
        {
            index -= count;
            while (index < 0)
                index += items.Length;
        }

    }
}
