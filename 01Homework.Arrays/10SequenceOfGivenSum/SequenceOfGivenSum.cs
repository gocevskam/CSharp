using System;

class Program
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 11;
        int numOfSums = 0, sum = 0, start = 0, end = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i + j < array.Length)                 
                {
                    sum = sum + array[i + j];   
                    if (sum == s)                
                    {
                        start = i;              
                        end = i + j;           
                        numOfSums++;            
                        Console.Write("the elements are: ");
                        for (int k = start; k <= end; k++)
                        {
                            Console.Write("{0}, ", array[k]);
                        }
                    }
                }
            }
            sum = 0; 
        }
    }
}