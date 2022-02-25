using System;

namespace const_3
{
    class employee
    {
        int empno, sal;
        string empname, desig;

        public employee()
        {
            empno = 1;
            empname = "Raju";
            desig = "CEO";
            sal = 500000;
        }
        public employee(int empno, string empname, string desig, int sal)
        {
            this.empno = empno;
            this.empname = empname;
            this.desig = desig;
            this.sal = sal;
        }
        public void display()
        {
            Console.WriteLine("Employee Number :"+empno);
            Console.WriteLine("Employee Name :"+empname);
            Console.WriteLine("Employee Designation :" + desig);
            Console.WriteLine("Employee Salary :" + sal);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------------employee Details-----------");
            employee employee = new employee();
            employee.display();
            Console.WriteLine("--------------employee Details-----------");
            employee employee2 = new employee(2,"shayam","manager",30000);
            employee2.display();
            Console.WriteLine("--------------Input Employee Details-----------");
            Console.WriteLine("Enter Employee Number");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            string desig = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            int sal = Convert.ToInt32(Console.ReadLine());
            employee employee1 = new employee(empno, empname, desig, sal);


            Console.WriteLine("--------------employee Details-----------");
            
            employee1.display();


            Console.ReadLine(); 

        }
    }
}