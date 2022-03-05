using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    class Program
    {
        public static void Main()
        {
            int i, n;
            Console.WriteLine("Enter number upto print prime num ");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n; i++)
            {
                if (i%2!=0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        
    }
}