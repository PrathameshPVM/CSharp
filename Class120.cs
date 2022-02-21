/* create a class calculate having fields num1,num2 and methods addition,substraction,
multiplication and division */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class calculate
    {
        int num1;
        int num2;
        int res;

        public void add(int num1,int num2)
        {
          res=num1 + num2;
        }
        public void disadd()
        {
            Console.WriteLine("Addition=" + res);
        }

        public void sub(int num1, int num2)
        {
            res = num1 - num2;
        }
        public void dissub()
        {
            Console.WriteLine("Substraction=" + res);
        }

        public void multi(int num1, int num2)
        {
            res = num1 * num2;
        }
        public void dismulti()
        {
            Console.WriteLine("Multiplication=" + res);
        }

        public void div(int num1, int num2)
        {
            res = num1 / num2;
        }
        public void disdiv()
        {
            Console.WriteLine("Division=" + res);
        }
    }
    internal class Class120
    {
        static void Main()
        {
            calculate m=new calculate();

            Console.WriteLine("Enter two numbers.");
            int num1, num2;

            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            m.add(num1,num2);
            m.disadd();

            m.sub(num1, num2);
            m.dissub();

            m.multi(num1, num2);
            m.dismulti();

            m.div(num1, num2);
            m.disdiv();

        }

       

    }
}
