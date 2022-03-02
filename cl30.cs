using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sp = -1;
			for (i = 5; i >= 1; i--)
			{
				for (j = 1; j <= i; j++)
					Console.Write("*");
				for (j = 1; j <= sp; j++)
					Console.Write("_");
				for (j = 1; j <= i; j++)
					if (j != 5)
						Console.Write("*");
				Console.WriteLine("\n");
				sp = sp + 2;
			}

		}
	}
}

