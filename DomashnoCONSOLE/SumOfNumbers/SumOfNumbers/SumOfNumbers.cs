using System;

    class SumOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("insert a number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 0;
             while (i <= n)
            {
                sum = sum + n;
                i++;
                 Console.Write("{0} + ", n);
            }

             Console.WriteLine("= {0}", sum);  
        }
    }

