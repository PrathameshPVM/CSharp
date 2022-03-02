using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl40
{
    class add
    {
        public int sumOfDigit(int num)
        {
            int s=0, a;
            s = s + (num % 10);
            a = num / 10;
            if (a > 0)
            {
                sumOfDigit(a);
            }
            return s;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            add add = new add();
            int num, sum;
            
            Console.WriteLine("Enter a number:");
            num=Convert.ToInt32(Console.ReadLine());
            sum = add.sumOfDigit(num);
            Console.WriteLine("The sum of digits of {0} is: {1}", num, sum);

        }
    }
}

