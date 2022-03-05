using System;

public class functionexcercise
{
    public static void interchangenumber(ref int num1, ref int num2)
    {
        int newnum;

        newnum = num1;
        num1 = num2;
        num2 = newnum;
    }
    public static void Main()
    {
        int n1, n2;
        Console.Write("Enter two number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        interchangenumber(ref n1, ref n2);
        Console.WriteLine("After swapping the 1st number is : {0} , and the 2nd number is : {1}", n1, n2);

        Console.ReadLine();
    }
}