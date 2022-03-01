using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl12
{
    public class program
    {
        public static void Main(string[] args)
        {
            int i, n, sign = 1;

            Console.WriteLine("Enter the nth term");
            n=Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i < 2*n-1; i=i+2)
            {
                Console.WriteLine(i*sign);
                sign=sign*(-i);
            }
            
        }
    }
}

