using System;

class MostFrequentElement
{
    static void Main(string[] args)
    {
        int[] array = { 4, 1, 1, 1,1,1,1,1,1,1,4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int subarrayLenght = 0;
        int maxsubSequence = 0;
        int bestIndex = 0;

          Array.Sort(array);

          for (int i = 0; i < array.Length-1; i++)
          {
              if (array[i]==array[i+1])
              {
                  subarrayLenght++;
              }
              else if (subarrayLenght > maxsubSequence)
              {
                  maxsubSequence = subarrayLenght;
                  bestIndex = i;
              }
              subarrayLenght = 1;

          }
        
          Console.WriteLine(array[bestIndex]);
      
    }
}

