//create a class student having fields rno, name, course, fees
//create a method getdata with no parameters , create overloaded method with 2 parameters, 3 parameters, 4 parameters and display method.

using System;

namespace const_6
{
    class student
    {
        public int rno,fee;
        public string name, course;

        public void getdata()
        {
            rno = 10;
            name = "Raju";
            course = "Java";
            fee = 20000;
        }
        public void getdata(int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void getdata(int rno, string name,string course)
        {
            this.rno = rno;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rno, string name, string course,int fee)
        {
            this.rno = rno;
            this.name = name;
            this.course= course;
            this.fee = fee;
        }
        public void display()
        {
            Console.WriteLine("Roll Number :" + rno);
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Course :" + course);
            Console.WriteLine("Fees :" + fee);

        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            student student = new student();
            student.getdata();
            Console.WriteLine("----------Student Details-----------");
            student.display();

            student student1 = new student();
            student1.getdata(21,"shyam");
            Console.WriteLine("----------Student Details-----------");
            student1.display();

            student student2 = new student();
            student2.getdata(31, "modi","politics");
            Console.WriteLine("----------Student Details-----------");
            student2.display();

            student student3 = new student();
            student3.getdata(41, "Amit","java",20300);
            Console.WriteLine("----------Student Details-----------");
            student3.display();

        }
    }
}