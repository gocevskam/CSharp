using System;

    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Insert a integer number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("is Even");
            }
            else
            {
                Console.WriteLine("is Odd");
            }
        }
    }

