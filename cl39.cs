using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl39
{
    class add
    {
       public int getSum(int aj)
        {
            
             int sum = 0;
            if (aj > 0)
            {
                sum = sum + aj;
                getSum(aj - 1);
            }
            return sum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            add a = new add();
            
            int n, sum;
            Console.WriteLine("\n\nEnter the range of n: ");
            n=Convert.ToInt32(Console.ReadLine());
            sum = a.getSum(n);
            Console.WriteLine("The sum of first {0} numbers is {1}", n, sum);
            

        }
    }
}

