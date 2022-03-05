using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        int num;  
        int i, j, k;

        
        Console.WriteLine("Enter size of the array: ");
        num = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < num; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        

        for (i = 0; i < num; i++)
        {
            for (j = i + 1; j < num; j++)
            {
                 
                if (arr[i] == arr[j])
                {
                    
                    for (k = j; k < num; k++)
                    {
                        arr[k] = arr[k + 1];
                    }
 
                    num--;

                     
                    j--;
                }
            }
        }

         
        Console.WriteLine("\nArray elements after deleting duplicates : ");
        for (i = 0; i < num; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.ReadLine();
    }

}