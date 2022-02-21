//using System;

//namespace switchh
//{
//    class switchh
//    {
//        static void Main()
//        {
//            int n1, n2,res;
//            Console.WriteLine("Enter two numbers");
//            n1 = Convert.ToInt32(Console.ReadLine());
//            n2 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Operator (+,-,*,/)");
//            char ope = Convert.ToChar(Console.ReadLine());

//            switch (ope)
//            {
//                case '+':
//                    res = n1 + n2;
//                    Console.WriteLine("Addition of {0} and {1} is = {2}" + n1, n2, res);
//                    break;

//                case '-':
//                    res = n1 - n2;
//                    Console.WriteLine("Substraction of {0} and  {1} is = {2}",n1,n2, res);
//                    break;

//                case '*':
//                    res = n1 * n2;
//                    Console.WriteLine("Multiplication of {0} and {1} is = {2}", n1, n2, res);
//                    break;

//                case '/':
//                    res = n1 / n2;
//                    Console.WriteLine("Division of {0} and  {1} is = {2}", n1, n2, res);
//                    break;

//                default:
//                    Console.WriteLine("Invalid Operator");
//                    break;

//            }
//        }
//    }
//}
