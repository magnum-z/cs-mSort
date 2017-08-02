using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_mSort
{
    class QuickSort
    {
        Random _pivotRng = new Random();
                
        public void Sort(int[] items)
        {
            quicksort(items, 0, items.Length - 1);
        }

        private void quicksort(int[] items, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);
                int newPivot = partition(items, left, right, pivotIndex);

                quicksort(items, left, newPivot - 1);
                quicksort(items, newPivot + 1, right);
            }
        }

        private int partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Program.SwapItems(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Program.SwapItems(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Program.SwapItems(items, storeIndex, right);
            return storeIndex;
        }

    }
}
