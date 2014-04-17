using System;



class MaximalSumOfElements
{
    static void Main()
    {
        Console.WriteLine("enter the number of the elements in the array:");
        int n= int.Parse(Console.ReadLine());
        int[] arrayN = new int[n];

        Console.WriteLine("Enter the number of the elements which will have a maximal sum: ");
        int k = int.Parse(Console.ReadLine());
        int[] arrayK = new int[k];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < arrayN.Length; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }
      
        int sum = 0;
        Array.Sort(arrayN);

            for (int i =n-1; i >=n - k ; i--)
            {
                sum += arrayN[i];
            }
          

        
        Console.WriteLine("The best sum is:{0}",sum);

    }
}

