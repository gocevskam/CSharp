using System;
using System.Numerics;
    class CatalianNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            BigInteger numerator = 1;
            BigInteger denomerator = 1;
            BigInteger result = 1;
            for (int i = 2*n; i >= n+1; i--)
            {
                numerator *= i;
            }
            for (int j = 1; j <= n +1; j++)
            {
                denomerator *= j;
            }
            result = numerator / denomerator;
            Console.WriteLine("the result is:{0}",result);
        }
    }

