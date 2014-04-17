using System;

   public class BiggerThanNeighbors
    {
       static int ChecksIfBiggerThanNeighbors(int[] array)
       {
           Console.WriteLine("enter the position number:");
           int posNumber = int.Parse(Console.ReadLine());
           int biggerNum = 0;
           for (int i = posNumber; i < array.Length - 1; i++)
           {
               if ((array[posNumber] > array[posNumber + 1]) && (array[posNumber] > array[posNumber - 1]))
               {
                   biggerNum = array[posNumber];
               }
               else
                   return -1;   // it returns zero if number not bigger than neighbors.
           }
           return biggerNum;

       }
        
        static void Main()
        {
            int[] array = { 2, 3, 4, 5, 6, 9, 5, 4, 10, 8 };
            Console.WriteLine(ChecksIfBiggerThanNeighbors(array));
        }
    }

