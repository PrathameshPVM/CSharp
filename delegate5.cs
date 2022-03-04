using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate5
{
   class publisher
    {
        public delegate int del1(int n1, int n2);

        public event del1 event1;

        public void raiseevent()
        {
            if (event1 != null)
            {
                event1(2, 3);
            }
            else
            {
                Console.WriteLine("No Subscriber");
            }
        }
    }
    public class program
    {
        public void addition(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Result : "+res);
        }
        public static void Main(string[] args)
        {
            publisher pb = new publisher();
            pb.raiseevent();
        }
    }
}

