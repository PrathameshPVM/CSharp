using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl31
{
    class Program
    {
        static void Main(string[] args)
        {
			int i, sum = 0;
			int[] arr=new int[10];
			
			for (i = 0; i < 10; i++)
			{
                Console.WriteLine("Enter any number");
				arr[i] = Convert.ToInt32(Console.ReadLine());
				sum = sum + arr[i];
			}

            for (i = 0; i < arr.Length; i++)
                Console.Write(" "+arr[i]);
            Console.WriteLine("The sum of numbers {0}", sum);

        }
	}
}

