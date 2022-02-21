/*3- create a class student having fields rno,name,mathsmarks, chemmarks,phymarks,
total, per,grade and method result to calculate and display total,per and grade*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        int rno;
        string name;
        int mathmarks;
        int chemarks;
        int phymarks;
        int total;
        float per;
        string grade;

        public void getdata()
        {
            Console.WriteLine("Enter eno,name,mathmarks,chemarks,phymarks");
            rno=Convert.ToInt32(Console.ReadLine());
            name=Console.ReadLine();
            mathmarks=Convert.ToInt32(Console.ReadLine());
            chemarks=Convert.ToInt32(Console.ReadLine());
            phymarks=Convert.ToInt32(Console.ReadLine());

            total=mathmarks+chemarks+phymarks;
            per = (total) / 0.3f * 100f;

            if(per>=75 && per<=100)
            {
                grade = "A";

            }
            else
            {
                grade = "B";
            }

         


        }
        public void dis()
        {
            Console.WriteLine("Rno=" + rno);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Total="+total);
            Console.WriteLine("Percentage=" + per);
            Console.WriteLine("Grade=" + grade);
        }
    }

   
    internal class Class123
    {
        static void Main()
        {
            student s = new student();

            s.getdata();
            s.dis();
        }
    }
}*/
