using System;

namespace inheritance5
{
    public class person
    {
        string name;
        string address;

        public void getpersondata(string name,string address)
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
    public class student:person
    {
        int rno;
        int marks;

        public void getstudentdata(int rno,int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
        
    }
    class program
    {
        public static void Main(string[] args)
        {
            student s1 = new student();

            s1.getpersondata("raju", "mumbai");
            s1.getstudentdata(111, 895);
            s1.displaystudentdata();
            s1.displaypersondata();
        }
    }
}