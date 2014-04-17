using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] array = {3, 5, 4, 6, 8, 9, 10, 11, 15, 4, 5, 2, 3 };
        int maxSequence = 0;
        int seqence = 1;
        int endIndex = 0;

        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            if (array[i] < array[i + 1])

                seqence++;
            else
            {

                if (seqence > maxSequence)
                {
                    maxSequence = seqence;
                    endIndex = i;
                }
                seqence = 1;
            }
        }
            if (seqence > maxSequence)
            {
                maxSequence = seqence;
                endIndex = array.Length - 1;
            }
            seqence = 1;
        
        Console.WriteLine("The longest sequence of increasing elements is:");
        for (int i = endIndex - maxSequence + 1; i < maxSequence; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}

