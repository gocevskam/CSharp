using System;

class CompareOfArrays
{

    static void Main()
    {
        Console.WriteLine("enter the number of elements in the first array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number of elements in the secound array");
        int m = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secoundArray = new int[m];
        bool areEqual = true;
        if (m == n)
        {
            Console.WriteLine("enter the elements of the first array");
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the elements of the secound array");
            for (int i = 0; i < m; i++)
            {
                secoundArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secoundArray[i])
                {
                    areEqual = false; break;
                }
            }
        }
        else
        {
            areEqual = false;
        }
        Console.WriteLine("Are the arrays equal? {0}", areEqual);
    }
}

