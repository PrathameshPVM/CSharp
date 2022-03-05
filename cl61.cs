using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int anglea, angleb, anglec, sum;

        Console.WriteLine("Input three angles of triangle : ");
        anglea = Convert.ToInt32(Console.ReadLine());
        angleb = Convert.ToInt32(Console.ReadLine());
        anglec = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum of all angles of triangle 
        sum = anglea + angleb + anglec;

        // Check whether sum=180 then its a valid triangle otherwise invalid triangle
        if (sum == 180)
        {
            Console.WriteLine("It is a valid triangle.\n");
        }
        else
        {
            Console.WriteLine("It is a invalid triangle.\n");
        }

        Console.ReadLine();
    }
}