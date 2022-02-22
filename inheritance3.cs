using System;

namespace inheritance3
{
    class person
    {
        public string Name;
        public string address;
    }
    class employee:person
    {
        public int empno;
        public float salary;
        public string designation;
    }
    class program
    {
       public static void Main(string[] args)
        {
            employee e1 = new employee();

            e1.Name = "raju";
            e1.address = "Saoner";
            e1.empno = 1256;
            e1.salary = 36521f;
            e1.designation = "Developer";

            Console.WriteLine("Name "+e1.Name);
            Console.WriteLine("Addreess " + e1.address);
            Console.WriteLine("Employee number " + e1.empno);
            Console.WriteLine("Salary " + e1.salary);
            Console.WriteLine("designation " + e1.designation);

        }
    }
}