
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl16
{
    public class program
    {
        public static void Main(string[] args)
        {
            int i, j;
            for ( i = 5; i <= 1; i++)
            {
                for ( j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }
            for (i = 2; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}

