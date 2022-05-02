using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_01_OOP_070_Loop_L2_generic
{
    class Loop<T>
    {
        private List<T> items;
        private int index = 0;
        public T Current
        {
            get
            {
                return items[index];
            }
        }
        public Loop(T[] items)
        {
            this.items = items.ToList();
        }
        public void Right(int count = 1)
        {
            index += count;

            while (index >= items.Count)
                index -= items.Count;
        }
        public void Left(int count = 1)
        {
            index -= count;

            while (index < 0)
                index += items.Count;
        }
        public void Insert(T n)
        {
            items.Insert(index + 1, n);
        }
        public void Delete()
        {
            items.RemoveAt(index);

            if (index > items.Count - 1) 
                index = 0;
        }
    }
}
