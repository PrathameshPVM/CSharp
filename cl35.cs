using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl35

{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int i;
            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Name");
                    a[i,j] = Convert.ToInt32(Console.ReadLine);
                } 
            }
            for ( i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.WriteLine(" "+a[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

