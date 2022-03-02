using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 2];
            int row, col;

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 2; col++)
                {
                    Console.WriteLine("enter rno and the marks");
                    a[row, col] = Convert.ToInt32(a[row, col]);

                }
            }
            Console.WriteLine(" rno and marks of 3 students are ");
            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 2; col++)
                {
                    Console.WriteLine(a[row, col]);
                }
                Console.WriteLine(" ");

            }
        }
    }
}

