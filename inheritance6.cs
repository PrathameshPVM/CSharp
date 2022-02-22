using System;

namespace inheritance6
{
    public class person
    {
        string name;
        string address;

        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);
        }
    }
    public class employee : person
    {
        int eno;
        string designation;

        public void getemployeedata(int eno, string designation)
        {
            this.eno = eno;
            this.designation = designation;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("Employee No : " + eno);
            Console.WriteLine("Designation : " + designation);

        }

    }
    class program
    {
        public static void Main(string[] args)
        {
            employee s1 = new employee();

            s1.getpersondata("raju", "mumbai");
            s1.getemployeedata(111, "developer");
            s1.displaystudentdata();
            s1.displaypersondata();
        }
    }
}