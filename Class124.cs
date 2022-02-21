/*4- create a class employee having fields empno,empname ,designation , basicsalary
and method calcuatesalary to display hra ie 32% of basicsalary, da ie 43%of basicsalary, ta ie 45% of basicsalary and totalsalary
(ie hra+da+ta+basicsalary)*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class employee
    {
        int empno;
        string empname;
        string designation;
        float basicsalary;
        float hra;
        float da;
        float ta;
        float total;

        public void getdata()
        {
            Console.WriteLine("Enter empno,empname,designation,basicsalary");
            empno=Convert.ToInt32(Console.ReadLine());
            empname=Console.ReadLine();
            designation=Convert.ToString(Console.ReadLine());
            basicsalary=Convert.ToSingle(Console.ReadLine());

            
            hra = 32 * basicsalary;
             da = 43 * basicsalary;
             ta = 45 * basicsalary;
             total = hra + da + ta;
        }
        public void display()
        {
            Console.WriteLine("Empno="+empno);
            Console.WriteLine("Empname="+empname);
            Console.WriteLine("Designation="+designation);
            Console.WriteLine("Basicsalary=" + basicsalary);
            Console.WriteLine("HRA=" + hra);
            Console.WriteLine("Da=" + da);
            Console.WriteLine("TA=" + ta);
            Console.WriteLine("Totalsalary=" + total);
        }
    }
    internal class Class124
    {
       static void Main()
        {
            employee emp = new employee();

            emp.getdata();
            emp.display();

        }
    }
}*/
