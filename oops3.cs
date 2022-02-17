using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        int empno;
        string empname;
        float salary;

        public void gatdata()
        {
            Console.WriteLine("enter employee no");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            salary = Convert.ToSingle(Console.ReadLine());

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

            emp.gatdata();
            emp.displaydata();

            Console.ReadLine();

        }
    }
}

