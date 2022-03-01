using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl18
{
    public class program
    {
        public static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 20; i++)
            {
                for (j = 1; j <= 40 - i; j++)  
                    
                Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine(" ");
            }

        }
    }
}

