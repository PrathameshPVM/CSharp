using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl14

{
    public class program
    {
        public static void Main(string[] args)
        {
            int i, n, s = 0;
            float avg;

            for (i = 1; i < 10; i++)
            {
                Console.WriteLine("Enter any number ");
                n=Convert.ToInt32(Console.ReadLine());

                s = s + n;

            }
            Console.WriteLine("The sum of ten numbers = {0} & average = {1}",s,s/10.0f);
        }
    }
}

