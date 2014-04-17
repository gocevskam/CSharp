using System;


    class Program
    {
        static void Main()
        {
            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int bestSum = int.MinValue;
            int endIndex = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    endIndex = i;

                    int sum = array[i] + array[i + 1];
                    if (sum > bestSum)
                        bestSum = sum;
                }
                
            }
            Console.WriteLine("{0},{1}, {2}",
                array[endIndex], array[endIndex -1], array[endIndex-2]);
            Console.WriteLine("the best sum is: {0}", bestSum);
        }
    }

