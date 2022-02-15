using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long m, f, t;
            float mp, fp;
            Console.WriteLine("Enter Total Numbers Of Males ");
            m =Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Total Numbers Of Female ");
            f =Convert.ToInt64(Console.ReadLine());

            t = m + f;
            Console.WriteLine("Total Number Of Males And Females =" + t);
            mp = (float)(m * 100) / t;
            fp = (float)(f * 100) / t;

            Console.WriteLine("Male Percentage = " + mp);
            Console.WriteLine("Female Percentage = " + fp);

            Console.ReadLine();
        }
    }
}

