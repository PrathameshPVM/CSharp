using System;

public class functionexcercise
{
    public static void welcome(string name)
    {
        Console.WriteLine("Welcome " + name);
    }
    public static void HaveAnice()
    {
        Console.WriteLine("Have a nice day");
    }
    public static void Main(string[] args)
    {
        string str1;
        Console.Write("Please Enter a name : ");
        str1 = Console.ReadLine();
        welcome(str1);
        HaveAnice();

        Console.ReadLine();
    }
}