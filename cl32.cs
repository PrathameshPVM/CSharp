using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl32
{
    class Program
    {
        static void Main(string[] args)
        {
			int  i, g = 0, s = 0;
			int[] a = new int[10];
			
			for (i = 0; i < 10; i++)
			{
				Console.WriteLine("Enter a number");
				a[i]=Convert.ToInt32(Console.ReadLine());

				if (a[i] > g)
					g = a[i];
				if (a[i] < s)
					s = a[i];
			}
			Console.WriteLine("The greatest no={0}", g);
			Console.WriteLine("The smallest no={0}", s);

		}
	}
}

