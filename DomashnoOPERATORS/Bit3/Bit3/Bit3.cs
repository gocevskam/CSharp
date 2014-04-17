using System;

class Bit3
{
    static void Main()
    {
        Console.WriteLine("insert an integer number:");
        int n = int.Parse(Console.ReadLine());
        int p = 4;
        int mask = 1 << p;
        int result = n & mask;
        if (result != 0)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }
    }
}

