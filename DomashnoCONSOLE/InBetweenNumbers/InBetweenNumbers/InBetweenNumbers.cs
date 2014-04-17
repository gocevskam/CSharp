using System;

    class InBetweenNumbers
    {
        static void Main()
        {
            Console.WriteLine("Insert a positive integer number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert secound positive integer number");
            int b = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p = p + 1;
                }
                
            }
            Console.WriteLine("From {0} to {1} there are {2} numbers that are devided by 5", a, b, p);
        }
    }

