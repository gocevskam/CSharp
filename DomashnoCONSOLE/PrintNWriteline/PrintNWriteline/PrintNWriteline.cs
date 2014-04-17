using System;

    class PrintNWriteline
    {
        static void Main()
        {
            Console.WriteLine("insert a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine(i);
            }
        }
    }

