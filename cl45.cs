using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl45
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 5; i++)
            {
                if (num == arr[i])
                {
                    Console.WriteLine("no found at position {0} ", i + 1);
                    break;

                }
            }
        }
    }
}

