using System;
  
 
class MaxSequenceInArray
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the sequence");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements:");
        int[] myArray = new int[n];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        int currlength = 1;
        int maxLength = 1;
        int startindex = 0;
        int beststart = 0;
        for (int i = 0; i < myArray.Length-1; i++)
        {
            if (i>=1 && myArray[i+1]==myArray[i])
            {
                currlength++;
            }
            if (currlength > maxLength)
            {
                maxLength = currlength;
                beststart = startindex;
            }
            else
            {
                currlength = 1;
                startindex = i + 1;
            }
        }
        Console.WriteLine("The array is:");
        for (int element = beststart; element < beststart + maxLength; element++)
        {
            Console.WriteLine(myArray[element]);
        }
        
    }
}
    
