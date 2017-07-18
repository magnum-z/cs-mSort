﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_mSort
{
    class Program
    {
        Random _pivotRng = new Random();

        void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

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

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }        

        static void Main(string[] args)
        {
            Program p = new Program();

            int[] ar = { 6, 4, 7, 1, 2, 8, 3, 5, 9, 0 };

            p.Sort(ar);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(ar[i]);
            }
            
        }
    }
}
