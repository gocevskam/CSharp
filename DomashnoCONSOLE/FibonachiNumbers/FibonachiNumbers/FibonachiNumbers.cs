using System;

    class FibonachiNumbers
    {
        static void Main()
        {
            uint a = 0;
            uint b = 1;
            for (int i = 0; i < 100; i++)
            {
                uint temp = a;
                a = b;
                b = b + temp;
                
                Console.WriteLine("{0}", a);
            }
        }
    }
