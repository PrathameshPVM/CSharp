using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    interface bank
    {
        String deposit(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal=bal+amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
        }
    }
}

