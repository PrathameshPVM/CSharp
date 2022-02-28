using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_5
{
    public class account
    {
        public int accno;
        public string name;
        public static int count=0;

        public account (int accno,string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            account a1 = new account(25, "raju");
            account a2 = new account(289, "rahul");
            account a3 = new account(152, "suresh");

            a1.display();
            a2.display();
            a3.display();

            Console.WriteLine("Total Object are :" + account.count);
        }
    }
}

