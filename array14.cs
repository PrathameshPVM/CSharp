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
            Console.WriteLine("enter no. of elements");
            string s = Console.ReadLine();
            int size = int.Parse(s);
            long[] row = new long[size]; 

            for (int i = 0; i < row.Length; i++)
            {
                Console.WriteLine("enter value");
                row[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < row.Length; i++)
            {

                Console.WriteLine(" " + row[i]);

            }


        }

    }
}
