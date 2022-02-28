using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl7
{
    public class program
    {
        public static void Main(string[] args)
        {
            int m1, m2, m3,t;
            float per;

            Console.WriteLine("Enter Marks of three subjects ");
            m1 =Convert.ToInt32(Console.ReadLine());
            m2 =Convert.ToInt32(Console.ReadLine());
            m3 =Convert.ToInt32(Console.ReadLine());

            //t = m1 + m2 + m3;
            per = (float)m1 + m2 + m3 / 300 * 100;
            Console.WriteLine(per);

            if(per >= 75)
            {
                Console.WriteLine("PASS Distinction & Percent = {0}", per);
            }
            else if(per >= 60)
            {
                Console.WriteLine("PASS First Division & Percent = {0}", per);
            }
            else if (per >= 45)
            {
                Console.WriteLine("PASS Second Division & Percent = {0}", per);
            }
            else if (per >= 35)
            {
                Console.WriteLine("PASS Third Division & Percent = {0}", per);
            }
            else
            {
                Console.WriteLine("Fail");
            }



        }
    }
}

