﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_6
{
    class account
    {
        public int actno;
        public int balance = 1000;

        public virtual string deposit(int actno, int amount)
        {
            return "deposit method of account class";
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
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully in current class";

        }
    }
    class saving:account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount+interest;
            return "amount deposited successfully with interest in saving class";
        }
    }
    public class program
    {
        public static void Main()
        {
            account ac = new current();
            Console.WriteLine("Enter Account Number :");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited :");
            int amount = Convert.ToInt32(Console.ReadLine());

            String res = ac.deposit(actno, amount);
            Console.WriteLine("Account number is :" + ac.actno);
            Console.WriteLine(res);
            res = ac.showbalance();
            Console.WriteLine(res);

            account sav = new saving();
            string res1=sav.deposit(actno, amount);
            Console.WriteLine("account no is " + sav.actno);
            Console.WriteLine(res1);
            res1=sav.showbalance();
            Console.WriteLine(res1);

        }
    }
}