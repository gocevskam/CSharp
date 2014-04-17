using System;

class SortArray
{
    static void Main()
    {
        int[] array = { 2, 5, 6, 4, 7, 15, 12, 3, 6, 9 };
        int minIndex = 0;
        int minValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            minIndex = i;
            minValue = array[i];

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < minValue)
                {
                    minIndex = j;
                    minValue = array[j];
                }
            }
            array[minIndex] = array[i];
            array[i] = minValue;
        }
        Console.WriteLine("The sorted array is:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

