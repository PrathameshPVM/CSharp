using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_3
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal=1000;
    }
    class saving : account,bank
    {
        public string deposit(int actno,int amt)
        {
            this .actno = actno;
            bal = bal + amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
            string str = b.deposit(1, 20225);
            Console.WriteLine(str);

        }
    }
}

