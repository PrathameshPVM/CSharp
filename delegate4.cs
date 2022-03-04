using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate4
{
    public delegate int del1(int n1, int n2);
    public class program
    {
        public int addition(int n1,int n2)
        {
            return n1 + n2;
        }
        public int substraction(int n1, int n2)
        {
            return n1 - n2;
        }
        public static void Main(string[] args)
        {
            program p1 = new program();

            del1 d1 = new del1(p1.addition);
            int res = d1(1, 2);
            Console.WriteLine("Addition : "+res);

            del1 d2 = new del1(p1.substraction);
            res=d2(1, 2);
            Console.WriteLine("Substraction : "+res);

        }
    }
}

