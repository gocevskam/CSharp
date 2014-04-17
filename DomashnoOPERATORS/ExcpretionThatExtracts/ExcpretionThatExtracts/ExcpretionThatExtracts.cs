using System;

class ExcpretionThatExtracts
{
    static void Main()
    {
        Console.WriteLine("Insert a integer number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert the bit number you'd like to check:");
        int b = int.Parse(Console.ReadLine());
        int mask = ~(1 << b);
        int result = a & mask;
        Console.WriteLine((a & mask) != 0 ? 1 : 0);
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));



    }
}

