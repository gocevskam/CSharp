using System;

    class nNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int number=1;
            while (number <= n)
            {
                
                Console.Write("{0},", number);
                number++;
            }
        }
    }

