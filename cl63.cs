using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int basenumber, exponent, power, i;

        // Reading number
        Console.Write("Enter any number: ");
        basenumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter any number: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        power = 1;
        i = 1;
        //caculatinh power of given number
        while (i <= exponent)
        {
            power = power * basenumber;
            i++;
        }
        Console.Write("Power : " + power);

        Console.ReadLine();
    }
}