using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {

        public static void Main()
        {
            //if else 
            //wap to accept 3 subject marks  and print total , per and grade.
            int n1, n2, n3, total;
            float per;
            String grade;
            Console.WriteLine("enter 3subject marks.");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            total = n1 + n2 + n3;
            per = (float)(total / 300.0f) * 100.0f;
            Console.WriteLine("total = " + total);
            Console.WriteLine("per = " + per);
            if (per >= 75)
            {
                grade = "distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "first";
            }
            else
            {
                grade = "fail";
            }


            Console.WriteLine("grede " + grade);

            Console.ReadLine();
        }
    }
}