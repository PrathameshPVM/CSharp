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
            long[] row = { 0, 1, 2, 3 };


            //displaying the array elements

            for (int j = 0; j < 4; j++)
            {
                Console.Write("\t " + row[j]);
            }
            Console.WriteLine();


        }

    }
}