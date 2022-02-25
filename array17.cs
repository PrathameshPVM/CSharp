using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array17
{
    class Program
    {
        static void Main()
        {
            int[] array = CreateArray(3);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static int[] CreateArray(int size)
        {
            int[] created = new int[size];
            created[0] = 1;
            created[1] = 2;
            created[2] = 3;
            return created;
        }

    }
}
