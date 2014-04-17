using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("enter the number of elements in the first array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number of elements in the secound array");
        int m = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        char[] secoundArray = new char[m];
        bool areEqual = true;
        if (n == m)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < secoundArray.Length; i++)
            {
                firstArray[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < secoundArray.Length; i++)
            {
                if (firstArray[i] != secoundArray[i])
                {
                    areEqual = false;
                }
            }
        }
        else
        {
            areEqual = false;
        }
        Console.WriteLine("the arrays are equal?{0} ", areEqual);

    }
}

