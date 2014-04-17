using System;

class ModifiesIntNum
{
    static void Main()
    {
        Console.WriteLine("Insert an integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert the number of the bit you'd like to be modified:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert value 1 or 0:");
        byte value = byte.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = 0;
        if (value == 1)
        {
            result = n | mask;

        }
        else
        {
            mask = ~(1 << p);
            result = n & mask;
        }

        Console.WriteLine("the modified number is {0}", result);

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

    }
}

