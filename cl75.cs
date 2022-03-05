using System;
class Program
{
    static void Main()
    {

        int[] arr1 = new int[100];
        int[] arr2 = new int[100];
        int[] mergeArray = new int[100];

        int size1, size2, mergeSize;
        int index1, index2, mergeIndex;
        int i;


        //Reads size of the array
        Console.WriteLine("Enter the size of 1st array :");
        size1 = Convert.ToInt32(Console.ReadLine());

        //Reads elements in array
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < size1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }


        //Reads size of the array
        Console.WriteLine("Enter the size of 2nd array :");
        size2 = Convert.ToInt32(Console.ReadLine());

        //Reads elements in array
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < size2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        mergeSize = size1 + size2;


        //Merging two array in ascending order
        index1 = 0;
        index2 = 0;
        for (mergeIndex = 0; mergeIndex < mergeSize; mergeIndex++)
        {

            //If all elements of one array is merged to final array
            if (index1 >= size1 || index2 >= size2)
            {
                break;
            }
            if (arr1[index1] < arr2[index2])
            {
                mergeArray[mergeIndex] = arr1[index1];
                index1++;
            }
            else
            {
                mergeArray[mergeIndex] = arr2[index2];
                index2++;
            }
        }

        //Merging the remaining elements of array
        while (index1 < size1)
        {
            mergeArray[mergeIndex] = arr1[index1];
            mergeIndex++;
            index1++;
        }
        while (index2 < size2)
        {
            mergeArray[mergeIndex] = arr2[index2];
            mergeIndex++;
            index2++;
        }

        //Print merged array
        Console.WriteLine("\nArray merged in ascending order : ");
        for (i = 0; i < mergeSize; i++)
        {
            Console.Write("\t" + mergeArray[i]); ;
        }

        Console.ReadLine();
    }

}