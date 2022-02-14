using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [3];
            arr [0] = 11;
            arr [1] = 22;
            arr [2] = 33;

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("arr = " +arr[i]);
            }
            foreach(int i in arr)
            {
                Console.WriteLine("arr = " + i);

            }
            Console.ReadLine();
        }
    }
}