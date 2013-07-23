using System;

class SortArray
{
    static int FindMaxInArrayAndPutItAtStartPoss(int start, int[] array)
    {
        int maxValue = int.MinValue;
        int index = 0;
        for (int i = start; i < array.Length; i++)
        {

            if (array[i] > maxValue)
            {
                maxValue = array[i];
                index = i;
            }
        }
        if (index!=start)
        {
            int temp = array[start];
            array[start] = maxValue;
            array[index] = temp;
        }
        
        return maxValue;
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] dataBase = { 1, 3, 5, 7, -2, -7, 12, 8, -14, 26, 25, 2, 6 };
        Console.Write("Please choose how to sort your array: a-ascending; d-descending: ");
        string input = Console.ReadLine();
        int[] workingArray = (int[])dataBase.Clone();
        int[] ascSortedArray = new int[dataBase.Length];
        for (int i = 0; i < dataBase.Length; i++)
        {
            FindMaxInArrayAndPutItAtStartPoss(i, workingArray);
        }
        if (input == "d")
        {
            PrintArray(workingArray);
        }
        else if (input == "a")
        {
            for (int i = 0; i < workingArray.Length; i++)
            {
                ascSortedArray[workingArray.Length - 1 - i] = workingArray[i];
            }
            PrintArray(ascSortedArray);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
      
    }
}
