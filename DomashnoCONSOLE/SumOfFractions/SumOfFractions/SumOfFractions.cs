using System;

class SumOfFractions
{
    static void Main()
    {
        double sum=0;
        double sum1=0;
        double sum2=0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = 1.0 / i;
                    sum2 = sum1 + (1.0 / i);
                }
                else
                {
                    sum1 = 1.0 / (-i);
                    sum2 = sum1 + (1.0 / (-i));
                }

                sum = 1 + sum1 + sum2;

            }
        Console.WriteLine("{0:0.000}",sum);
    }
}

