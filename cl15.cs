using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl15
{
    public class program
    {
        public static void Main(string[] args)
        {
            int i, n = 0, g = 32768, b = 32767;
            for (i = 1; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                n=Convert.ToInt32(Console.ReadLine());

                if (n>g)
                {
                    g = n;
                }
                else if (n<b)
                {
                    b = n;
                }
                
            }
            Console.WriteLine("The greatest no = "+g);
            Console.WriteLine("The smallest no = " + b);
        }
    }
}

