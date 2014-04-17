using System;
using System.Numerics;
    class SumOfFractionFactorials
    {
        static void Main()
        {
            Console.Write("enter N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter X=");
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal numerator = 1;
            decimal denominator = 1;
            for (int i = 1; i <= n; i++)
            {
                    numerator *= i;
                    denominator *= x;
                    sum = sum + (numerator / denominator);
            }
            
            Console.WriteLine("S=1+1!/{0} + 2!/{0}^2 +....+ {1}!/{0}^{1}={2}", x , n, sum);
        }
    }

