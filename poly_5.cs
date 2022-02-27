using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_5
{
    class account
    {
        public int actno;
        public int balance;

        public virtual string deposit(int actno,int amount)
        {
            return "Deposit method of account class";
        }
        public string showbalance()
        {
            return "balance amount :" + balance;
        }
    }
    class current : account
    {
        public override string deposit(int actno, int amount)
        {
            this .actno = actno;
            balance = balance + amount;
            return "amount deposited successfully in current class";
        }
    }
    public class program
    {
        public static void Main()
        {
            account ac = new current();
            string res = ac.deposit(123, 2000);
            Console.WriteLine(res);
            res= ac.showbalance();
            Console.WriteLine(res);
        }
    }
}