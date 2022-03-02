using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl36
{
    class cal
    {
        int y;


        int add(int m, int n)
        {
            if (n == 0)
                return m;

            y = add(m, n - 1) + 1;
            return y;
        }
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            cal cal = new cal();
            Console.WriteLine("       Studytonight - Best place to learn      ");
            int a, b, r;
            Console.WriteLine("Enter the two numbers:\n");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            cal.add(a, b);     
            Console.WriteLine("     Sum of two numbers is: %d\n\n", r);
            Console.WriteLine("        Coding is Fun !       ");

        }
    }
}

