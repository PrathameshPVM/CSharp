using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl38
{
    class fibo
    {
        public void printFibo(int aj)
        {
            int first = 0, second = 1, sum;
            if (aj > 1)
            {
                sum = first + second;
                first = second;
                second = sum;
                Console.WriteLine(sum);
                printFibo(aj - 1);    // recursive call
            }
            else
            {
                // after the elements, for line break
                Console.WriteLine("    ");
            }

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            fibo fibo = new fibo();
            Console.WriteLine("Studytonight - Best place to learn");
            int k, n;
            int i = 0, j = 1;
            Console.WriteLine("Enter the length of the Fibonacci series: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first {0} terms of Fibonacci series are:", n);
            Console.WriteLine("%d ", 1);
            fibo.printFibo(n);
            Console.WriteLine("Coding is Fun !");

        }
    }
}

