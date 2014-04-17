using System;

    class DevideBy3and7
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
           while(i<=n)
            {
                if (((i % 3) != 0) || ((i % 7) != 0))

                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }
    }

