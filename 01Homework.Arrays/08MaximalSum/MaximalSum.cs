using System;

    class MaximalSum
    {
        static void Main()
        {
            int[] array = { 2, 3, -6, 4, 8, 8 ,- 6, -1, -8, -1, };
            int bestSum = 0;
            int sum = 0;
            int lowerIndex = 0;
            int upperIndex = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    upperIndex = i;
                    
                }

                if (sum < 0)
                    lowerIndex = i - 1;
            }
            for (int i = lowerIndex; i <= upperIndex; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            

        }
    }

