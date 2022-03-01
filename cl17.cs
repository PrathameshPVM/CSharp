
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl17
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num,i;

            Console.WriteLine("Enter a number");
            num=Convert.ToInt32(Console.ReadLine());

            i = 2;
            while (i<num-1)
            {
                if (num%i==0)
                {
                    Console.WriteLine("Not a prime no");
                    break;
                }
                i++;
            }
            if (i==num)
            {
                Console.WriteLine("Prime Number");
            }
            


        }
    }
}

