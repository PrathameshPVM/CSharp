using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_data_samename
{
    class Employee
    {
        int empno;
        string empname;
        float salary;

        public void getdata(int empno, string empname, float salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }
        public void displaydata()
        {
            Console.WriteLine("empno " + empno);
            Console.WriteLine("empname " + empname);
            Console.WriteLine("salary " + salary);

        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("enter employee no");
            int eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            String en = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            float sal = Convert.ToSingle(Console.ReadLine());

            emp.getdata(eno, en, sal);
            emp.displaydata();

            Console.ReadLine();

        }
    }
}

