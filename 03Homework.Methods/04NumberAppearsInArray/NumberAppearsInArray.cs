using System;

    public class NumberAppearsInArray
    {
        public static int counter;
        public static int x;

        public static void NumberApperasinArray(params int[] elements)
        {
     
           
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == x)
                    counter++;
            }
            Console.WriteLine("the number {0} appears {1} times in the array. ", x, counter);
        }

        static void Main()
        {
            Console.WriteLine("Enter the number you'd like to check:");
             x = int.Parse(Console.ReadLine());
            int[] array = { 3, 4, 5, 3, 5, 5, 7, 5, 3, 6, 5};
            NumberApperasinArray(array);
        }
    }

