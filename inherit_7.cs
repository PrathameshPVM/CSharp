//repeat the above program for person and employee class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class employee : Person
    {
        int empno;
        int salary;
        public void getemployeeData(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayemployeeData()
        {
            Console.WriteLine("Employee Number : " + empno);
            Console.WriteLine("Employee Salary : " + salary);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            employee p1 = new employee();//creating object of child class\
            p1.getPersonData("arifa", "nagpur");
            p1.getemployeeData(111, 22999);
            p1.displayemployeeData();
            p1.displayPersonData();

        }
    }

}
