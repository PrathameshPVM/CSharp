//create a base class person having fields name and address,create a derieved 
//    class employee having fields empno, salary and designation
using System;

namespace inherit_4
{
   public class person
    {
        public string name;
        public string address;
    }
    public class employee:person
    {
        public int empno;
        public int salary;
        public string desig;
    }
    public class program
    {
        public static void Main()
        {
            employee e1 = new employee();

            e1.name = "Raju";
            e1.address = "mumbai";
            e1.empno = 101;
            e1.salary = 50000;
            e1.desig = "Manager";

            Console.WriteLine("Name :" + e1.name);
            Console.WriteLine("Address :" + e1.address);
            Console.WriteLine("Employee Number :" + e1.empno);
            Console.WriteLine("Employee Salary :" + e1.salary);
            Console.WriteLine("Employee Designation :" + e1.desig);

        }
        

        

    }
}