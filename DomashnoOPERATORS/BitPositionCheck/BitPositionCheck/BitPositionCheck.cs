using System;

    class BitPositionCheck
    {
        static void Main()
        {
            Console.WriteLine("insert a integer number:");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("insert the bit position you'd like to check:(if value of p=1-->false)");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int result = v & mask;
            if (result != 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
          
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

        }
    }

