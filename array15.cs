using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            long[] row = new long[4] { 1, 2, 3, 4 };
            long[] copy = row;

            row[0]++;
            long value = copy[0];
            Console.WriteLine(value + "\n");


            
            for (int i = 0; i < copy.Length; i++)
            {

                Console.WriteLine(" " + copy[i]);

            }


        }

    }
}
