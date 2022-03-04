using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace delegates3
{
    public delegate int del_square(int n1);

    public class program
    {
        public int square(int n1)
        {
            return n1 * n1;
        }
        public static void Main(string[] args)
        {
            program p =new program();
            del_square d1 = new del_square(p.square);
                int res = d1(3);
            Console.WriteLine("Square : "+res);
        }
    }
}

