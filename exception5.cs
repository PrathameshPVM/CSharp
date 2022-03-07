using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception5
{
    public class program
    {
        public static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("Enter Age = ");
                age=Convert.ToInt32(Console.ReadLine());
                if (age<18)
                {
                    throw new Exception("Age should be greater or equal to 18");
                    age = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter age 18 or greater than 18");
                age=Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally block is executing");
                Console.WriteLine("Age = "+age);
            }
            Console.WriteLine("BYE");
        }
    }
}

