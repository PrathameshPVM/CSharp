using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }

        }
    }
}

