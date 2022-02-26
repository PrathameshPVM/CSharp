using System;

namespace inherit_2
{
    public class person
    {
        public String name;
        public String address;
    }
    public class student: person
    {
        public int rno;
        public int marks;
    }
    class program
    {
        public static void Main()
        {
            student p1 = new student();
            p1.rno = 12;
            p1.name = "amit";
            p1.address = "Nagpur";
            p1.marks = 75;

            Console.WriteLine("rno: " + p1.rno);
            Console.WriteLine("name: " + p1.name);
            Console.WriteLine("address: " + p1.address);
            Console.WriteLine("marks: " + p1.marks);
        }
    }
}