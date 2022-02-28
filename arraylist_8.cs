using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_8
{
    class student
    {
        public int rno;
        public string name;

        public student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            student s1 = new student(12, "amit");
            student s2 = new student(14, "Raj");
            student s3 = new student(15, "Raman");

            ArrayList al = new ArrayList();

            al.Add(s1);
            al.Add(s2);
            al.Add(s3);

            foreach(student s in al)
            {
                Console.WriteLine("RNO :"+s.rno);
                Console.WriteLine("Name :" + s.name);
            }
        }
    }
}

