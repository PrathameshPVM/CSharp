using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl37
{
    class facto
    {
        public int fact(int aj)
        {
            if (aj == 1 || aj == 0)

                return 1;
            else
                return (aj * fact(aj - 1));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            facto fact = new facto();
            Console.WriteLine("      Studytonight - Best place to learn       ");
            int num, f;
            Console.WriteLine("   Enter a number: ");
            num=Convert.ToInt32(Console.ReadLine());
            f = fact.fact(num);
            Console.WriteLine("   Factorial of  {0} is  {1}  ", num, f);
            Console.WriteLine("         Coding is Fun !      ");

        }
    }
}

