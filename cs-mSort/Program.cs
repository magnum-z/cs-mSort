using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_mSort
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort sort = new QuickSort();

            int[] ar = { 6, 4, 7, 1, 2, 8, 3, 5, 9, 0 };

            sort.Sort(ar);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(ar[i]);                
            }            
        }
    }
}
