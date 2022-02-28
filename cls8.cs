using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls8
{
    public class program
    {
        public static void Main(string[] args)
        {
            int m1, m2, m3, g;

            Console.WriteLine("Enter any 3 numbers");
            m1= Convert.ToInt32(Console.ReadLine());
            m2= Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());

            if(m1>m2 && m1>m3)
            {
                Console.WriteLine("{0} is greater", m1);
            }
            else if(m2>m1 && m2>m3)
            {
                Console.WriteLine("{0} is greater", m2);
            }
            else
            {
                Console.WriteLine("{0} is greater", m3);
            }
        }
    }
}

