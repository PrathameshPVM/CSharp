using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception3
{ 
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int n;

            Console.WriteLine("Enter number first");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number second");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n;
            }
            catch (Exception ee)
            {
                Console.WriteLine("Connot Divide by Zero");
            }
            Console.WriteLine("Res = " + res);
            Console.WriteLine("Bye");
        }
    }
}

