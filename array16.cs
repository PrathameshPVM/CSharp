using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array16

{
    class Program
    {
        static void Main()
        {
            long[] row = new long[4] { 1, 2, 3, 4 };

            Console.WriteLine("array rank " + row.Rank);
            Console.WriteLine("array length " + row.Length);

            long[,] row1 = new long[2, 4];

            Console.WriteLine("array rank " + row1.Rank);
            Console.WriteLine("array length " + row1.Length);




        }

    }
}
