using System;

    class SumOfFibonachiNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of the first Fibonachi numbers you'd like to check the sum of:");
            int n = int.Parse(Console.ReadLine());
            uint a = 0;
            uint b = 1;
            uint sum = 0;
            for (int i = 0; i <=n; i++)
            {
                uint temp = a;
                a = b;
                b = b + temp;
                sum += a;
            }
            Console.WriteLine("the sum of the first n-Fibonachi numbers is:{0}",sum);
        }
    }

