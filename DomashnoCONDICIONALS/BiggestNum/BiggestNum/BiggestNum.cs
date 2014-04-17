using System;

class BiggestNum
{
    static void Main()
    {
        Console.Write("enter n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter m=");
        int m = int.Parse(Console.ReadLine());
        Console.Write("enter s=");
        int s = int.Parse(Console.ReadLine());
        int biggestNumber = 0;
        if ((n > m) && (n > s))
        {
            biggestNumber = n;
        }
        else
            if (m > s)
            {
                biggestNumber = m;
            }
            else
            {
                biggestNumber = s;
            }
   

        Console.WriteLine("the biggest number is:{0}", biggestNumber);


    }
}

