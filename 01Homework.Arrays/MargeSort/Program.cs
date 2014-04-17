using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void MergeSort(int[] array, int len)
    {
        int count = len;
        if (count == 2)       // At the moment when this value is achived it means that the array 'left' consists of 2elements 
        //And we can easily compare 
        {
            int temp;
            if (array[0] > array[1])
            {
                temp = array[0];
                array[0] = array[1];
                array[1] = temp;
            }
        }
        else if (len > 2)                     // Else we devide the lenght of the array in 2 (len/2)
        {
            count = len / 2;
            int[] left = new int[count];
            int[] right = new int[count + 1];
            for (int i = 0; i < count; i++)
            {
                left[i] = array[i];
            }
            for (int i = count; i < len; i++)
            {
                right[i - count] = array[i];
            }
            MergeSort(left, count);
            MergeSort(right, len - count);
            int p = 0;                                        //After the exchange of the elements we start filling the array
            int v = 0;
            for (int k = 0; k < len; k++)
            {
                if (p < count && v <= count && left[p] <= right[v])
                {
                    array[k] = left[p];
                    p++;
                }
                else
                {
                    array[k] = right[v];
                    v++;
                }
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Lenght of the array?");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers:");
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(array, n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
