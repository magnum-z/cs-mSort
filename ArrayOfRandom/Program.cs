using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            if (args.Length == 1)
                size = int.Parse(args[0]);

            Random rnd = new Random();
            int number;
            int split = 0;

            Console.Write("int[] ar = { ");
            for (int i = 0; i < size; i++)
            {
                number = rnd.Next(0, 1000);
                Console.Write(number);
                if(i < size - 1)
                    Console.Write(", ");
                split++;
                if(split == 15)
                {
                    Console.WriteLine();
                    split = 0;
                }
            }
            Console.WriteLine(" };");
        }
    }
}
