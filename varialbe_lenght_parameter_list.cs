using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varialbe_lenght_parameter_list
{
    class Program
    {
        static long AddList(params long[] v)
        {
            long total,i;
            for(i=0,total=0; i<v.Length; i++)
            {
                total +=v[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            long x = AddList(1,2,3,4,5);
            Console.WriteLine("value of x = " +x);

        }
    }
}

