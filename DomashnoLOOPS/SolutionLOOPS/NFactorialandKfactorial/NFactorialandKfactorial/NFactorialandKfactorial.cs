using System;
using System.Numerics;

    class NFactorialandKfactorial
    {
        static void Main()
        {
            Console.Write("enter N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter K=");
            int k = int.Parse(Console.ReadLine());
            BigInteger resultNFactoriel = 1;
            BigInteger resultKfactoriel = 1;
            BigInteger finalResult = 1;

            for (int i = 1; i <= n; i++)
            {
                resultNFactoriel *= i;
            }
            Console.WriteLine(resultNFactoriel);

            for (int j = n+1; j <= k; j++)
            {
                resultKfactoriel *= j;
            }
            Console.WriteLine(resultKfactoriel);

            finalResult = resultNFactoriel * resultKfactoriel;
            Console.WriteLine("N!*K!/(N-K)!={0}", finalResult);
        }
    }

