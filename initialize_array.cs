using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initialize_array
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = new long[4] { 0, 1, 2, 3 };
            for (int j = 0;j<4;j++)
            {
                Console.WriteLine("\t" +arr[j]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

