using System;

    class SumOfInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 integer numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the three numbers is  " + (a + b + c) );
        }
    }

