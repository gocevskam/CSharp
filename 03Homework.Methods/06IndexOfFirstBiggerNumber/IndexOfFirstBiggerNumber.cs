
using System;

class FirstBiggerThenNeighbors
{
    static int BiggerNeighborFinder(int[] array)
    {
        int index = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;

    }
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5, 4, 7, 8 };
        Console.WriteLine("the number with index {0}, is the first bigger than its neighbors.", BiggerNeighborFinder(myArray));
    }
}

