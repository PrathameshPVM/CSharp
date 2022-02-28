using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_4
{
    public class account
    {
        public int accno;
        public string name;
        public static float roi = 8.8f;

        public account(int accno,string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno+" "+name+" "+roi);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            account.roi = 10.5f;
            account a = new account(15, "jay");
            account b = new account(18, "raju");

            a.display();
            b.display();
        }
    }
}

