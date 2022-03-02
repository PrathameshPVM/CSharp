using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise33
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}
