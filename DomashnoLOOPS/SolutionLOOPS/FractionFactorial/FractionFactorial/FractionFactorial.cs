using System;
using System.Numerics;
    class FractionFactorial 

    {
        static void Main()
        {
            Console.Write("enter a number n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter a number k=");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = k+1; i <= n; i++)
            {
                result *= i;
            }

                Console.WriteLine("N!/K!={0}", result);
            
        }
    }

