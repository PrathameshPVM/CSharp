using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl33
{
    class Program
    {
        static void Main(string[] args)
        {
			int i, j, temp = 0;
			int[] a = new int[10];
			for (i = 0; i < 10; i++)
			{
				Console.WriteLine("Enter a number");
				a[i]= Convert.ToInt32(Console.ReadLine());
			}
			for (i = 0; i < 10; i++)
			{
				for (j = i + 1; j < 10; j++)
					if (a[i] < a[j])
					{
						temp = a[i];
						a[i] = a[j];
						a[j] = temp;
					}
			}
			Console.WriteLine("The increasing order is");
			for (i = 0; i < 10; i++)
				Console.WriteLine( a[i]);

		}
	}
}

