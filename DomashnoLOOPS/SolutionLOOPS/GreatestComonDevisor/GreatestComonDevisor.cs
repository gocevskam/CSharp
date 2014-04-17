using System;

class GreatestComonDevisor
{
    static void Main()
    {
        Console.Write("enter a number n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter a number m=");
        int m = int.Parse(Console.ReadLine());
        int temp = 0;
        if (m < n)
        {
            temp = m;
            m = n;
            n = temp;
        }
        while (n != 0)
        {
            temp = m % n;
            m = n;
            n = temp;
        }
        Console.WriteLine(m);


    }
}

