using System;
using System.Numerics;
    class CountZeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            int zeroCount = 0;
            int x = 5;
            int denominator = 1;
            for (int i = 1; i <=n; i++)
            {
                factoriel *= i;
                denominator *= x;
                zeroCount += n / denominator;
            }
            Console.WriteLine("The number of zeros is:{0}",zeroCount);
        }
    }

