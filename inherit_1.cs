using System;

namespace inherit_1
{
    public class employee
    {
        public float salary = 40000;
    }
    public class programmer : employee
    {
        public float bonus = 1000;
    }

    public class program
    {
        public static void Main()
        {
            programmer p1 = new programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

        }
    }
}