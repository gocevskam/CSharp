using System;
using System.Collections.Generic;
using System.Linq;

class ArraysOfDigits
{
    static void Main()
    {
        byte[] num1 = { 0, 1 };
        byte[] num2 = { 9, 9 };
        PrintArray(SumDigits(num1, num2));
        Console.WriteLine();
    }
    static void PrintArray(List<int> list)
    {
        list.Reverse();
        foreach (var item in list)
        {
            Console.Write(item);
        }
    }
    static List<int> SumDigits(byte[] a, byte[] b)
    {
        var res = new List<int>();
        int mind = 0;
        int len = Math.Max(a.Length, b.Length);
        for (int i = 0; i < len; i++)
        {
            int digit = (i < a.Length ? a[i] : (byte)0) + (i < b.Length ? b[i] : (byte)0) + mind;
            mind = digit / 10;
            res.Add(digit % 10);
        }
        if (mind == 1) res.Add(1);
        return res;
    }

}
