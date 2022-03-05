using System;
class Program
{
    static void Main()
    {

        int[] arrayA = new int[10];
        int lengthA = arrayA.Length;
        Console.WriteLine("Length of ArrayA : {0}", +lengthA);
        long longLength = arrayA.LongLength;
        Console.WriteLine("Length of the Long Length Array  : {0}", longLength);
        int[,] twoD = new int[20, 50];
        Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
        Console.ReadLine();
    }
}