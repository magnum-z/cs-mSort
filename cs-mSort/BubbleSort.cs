using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_mSort
{
    class BubbleSort
    {
        private void bubblesort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 0; j <= i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Program.SwapItems(array, j, j + 1);
                    }
                }
        }

        public void Sort(int[] array)
        {            
            bubblesort(array);            
        }
    }
}
