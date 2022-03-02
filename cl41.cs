using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl41
{
    class pal
    {
        public int power(int b, int e)
        {
            if (e == 0)
                return 1;

            return (b * power(b, e - 1));
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            pal pal = new pal();
            
            int base1, exp,m;
            Console.WriteLine("Enter base number: ");
            base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nEnter Power factor: ");
            exp = Convert.ToInt32(Console.ReadLine());
            m = pal.power(base1, exp);
            Console.WriteLine("{0}^{1} = {2}", base1, exp,m);
            

        }
    }
}

