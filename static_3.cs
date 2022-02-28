using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_3
{
    public class account
    {
        public int accno;
        public string name;
        public static float rot = 8.8f;

        public account (int accno,string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno+" "+name+" "+rot);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            account a = new account(11, "jay");
            account b = new account(112, "raju");
            a.display();
            b.display();
        }
    }
}

