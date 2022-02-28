using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl2
{
    public class program
    {
        public static void Main(string[] args)
        {
            long m, f, t;
            float mp, fp;

            Console.WriteLine("Enter total number of males and female");
            m=Convert.ToInt64(Console.ReadLine());
            f=Convert.ToInt64(Console.ReadLine());

            t = m + f;

            Console.WriteLine("Total number of males and female :"+t);

            mp = m * 100 / t;
            fp = m * 100 / t;

            Console.WriteLine("Total Male Percentage is {0} and Total Female Percentage is {1}", mp, fp);
        }
    }
}

