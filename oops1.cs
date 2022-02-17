using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Employee
    {
        public int empno;
        public string empname;
        public float salary;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empno = 123;
            emp.empname = "raju";
            emp.salary = 12345.645f;

            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("salary " + emp.salary);
            Console.ReadLine();

        }
    }
}

