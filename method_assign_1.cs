//- create a class calculate having fields num1,num2 and methods addition,substraction,
//multiplication and division

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace method_assign_1
{
    class Calculate
    {
        public int num1;
        public int num2;
        public int res;

        public void add()
        {
            res = num1 + num2;
            Console.WriteLine("Addition : " + res);
            Console.ReadLine();
        }
        public void sub()
        {
            res = num1 - num2;
            Console.WriteLine("Substraction : " + res);
            Console.ReadLine();
        }
        public void mul()
        {
            res = num1 * num2;
            Console.WriteLine("Multiplication : " + res);
            Console.ReadLine();
        }
        public void div()
        {
            res = num1 / num2;
            Console.WriteLine("Division : " + res);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            
            Console.WriteLine("Enter num1 :");
            calc.num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2 :");
            calc.num2 = Convert.ToInt32(Console.ReadLine());

            calc.add();
            calc.sub();
            calc.mul();
            calc.div();
        }
    }

}