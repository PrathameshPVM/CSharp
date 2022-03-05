using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {
        int lower, higher, i, temp1, temp2, remainder, n = 0;
        double result = 0;

        
        Console.Write("Please Enter two numbers: ");
        lower = Convert.ToInt32(Console.ReadLine());
        higher = Convert.ToInt32(Console.ReadLine());

        Console.Write("Armstrong numbers between " + lower + " and " + higher + " are: ");

        for (i = lower + 1; i < higher; ++i)
        {
            temp2 = i;
            temp1 = i;

            
            while (temp1 != 0)
            {
                temp1 /= 10;
                ++n;
            }

            
            while (temp2 != 0)
            {
                remainder = temp2 % 10;
                result += Math.Pow(remainder, n);
                temp2 /= 10;
            }

           
            if (result == i)
            {
                Console.WriteLine(i);
            }

           
            n = 0;
            result = 0;

        }

        Console.ReadLine();
    }
}