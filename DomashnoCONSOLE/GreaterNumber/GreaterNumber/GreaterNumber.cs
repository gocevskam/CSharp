using System;

    class GreaterNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer number");
            int b = int.Parse(Console.ReadLine());
            int greater = Math.Max(a,b);
            Console.WriteLine("The greater number is {0}", greater);
        }
    }

