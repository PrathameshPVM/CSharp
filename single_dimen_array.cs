using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_dimen_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[3];
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Enter marks");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine("marks " +arr[i]);
            }
        }
    }
}

