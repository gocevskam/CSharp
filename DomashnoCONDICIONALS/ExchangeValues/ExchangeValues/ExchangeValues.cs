using System;

    class ExchangeValues
    {
        static void Main()
        {
            Console.WriteLine("enter an integer number: N=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a second integer number: M=");
            int m = int.Parse(Console.ReadLine());
            if (n > m)
            {
                int temp = n;
                n = m;
                m = temp;
                Console.WriteLine("N is greater than M and the values had been changed. N={0},M={1}", n, m);
            }
            else
            {
                Console.WriteLine("N isn't greater than M");
            }
        }
    }

