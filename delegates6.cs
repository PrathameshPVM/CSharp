using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates6
{
    class publisher
    {
        public delegate void del1(int n1, int n2);
        public event del1 event1;
        public void raiseevent(int n1,int n2)
        {
            if (event1 != null)
            {
                event1(2, 3);
            }
            else
            {
                Console.WriteLine("No Subscribtion");
            }
        }
    }
    public class program
    {
        public void addition(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("result " + res);
        }

        public static void Main(string[] args)
        {
            program p = new program();
            publisher pb = new publisher();
            pb.event1 += new publisher.del1(p.addition);
            pb.raiseevent(3,5);

        }
    }
}

