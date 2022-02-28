using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl1

{
    public class program
    {
        public static void Main(string[] args)
        {
            float c, a, r;
            r = 4.2f;
            c = 2 * 3.14f * r;
            a = 3.14f * r * r;

            Console.WriteLine("Radius is {0} Circumferance is {1} and Area is {2} ",r,c,a);
        }
    }
}

