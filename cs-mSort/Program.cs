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

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ar[i]);
                if (i < 9 )
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
