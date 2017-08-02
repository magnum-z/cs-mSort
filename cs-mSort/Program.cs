using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_mSort
{
    class Program
    {
        public static int length_array;
        public static int count_swap;
        public static TimeSpan time_exec;


        static void quick_sort(int[] array)
        {
            count_swap = 0;            
            var watch = System.Diagnostics.Stopwatch.StartNew();

            QuickSort sort = new QuickSort();
            sort.Sort(array);

            watch.Stop();
            time_exec = watch.Elapsed;
            length_array = array.Length;
        }

        static void bubble_sort(int[] array)
        {
            count_swap = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            BubbleSort sort = new BubbleSort();
            sort.Sort(array);

            watch.Stop();
            time_exec = watch.Elapsed;
            length_array = array.Length;
        }

        public static void SwapItems (int[] array, int indexLeft, int indexRight)
        {
            if (indexLeft != indexRight)
            {
                int temp = array[indexLeft];
                array[indexLeft] = array[indexRight];
                array[indexRight] = temp;
                count_swap++;
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(" ");
            }            
        }

        static void PrintSummerySort(string name_sort)
        {
            Console.WriteLine();
            Console.WriteLine(name_sort + ":");
            Console.WriteLine("    count of items = {0}", length_array);
            Console.WriteLine("    time = {0}", time_exec);
            Console.WriteLine("    count of swap = {0}", count_swap);            
        }

        static int[] CreateRandomArray(int size)
        {
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }
            return array;
        }

        static void Main(string[] args)
        {

            int[] ar1 = CreateRandomArray(5000);
            int[] ar2 = new int[ar1.Length];
            ar1.CopyTo(ar2, 0);
                        
            bubble_sort(ar1);            
            PrintSummerySort("Bubble sort");
                        
            quick_sort(ar2);            
            PrintSummerySort("Quick sort");

            //PrintArray(ar1);
        }
    }
}
