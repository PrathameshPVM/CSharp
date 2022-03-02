using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2,3 }, { 3, 4,5 }, { 5, 6,7 }, { 7, 8,8 }, { 9, 10 ,11} };
            int i, j;


            for (i = 0; i < 3; i++)
            {

                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}",array[i, j]);
                }
            }

        }
    }
}

