using System;

class ProductOfRealNum
{
    static void Main()
    {
        Console.Write("n=");
        double n = double.Parse(Console.ReadLine());
        Console.Write("m=");
        double m = double.Parse(Console.ReadLine());
        Console.Write("s=");
        double s = double.Parse(Console.ReadLine());
        bool positive = true;
        if (n < 0)
        {
            if (m < 0)
            {
                if (s < 0)
                {
                    positive = false;
                }

                positive = true;
            }

            else
            {
                if (s < 0)
                {
                    positive = true;
                }
                positive = false;
            }
        }
        if (positive)
        {
            Console.WriteLine("The sign is +");
        }
        else
            Console.WriteLine("The sign is -");
       
    }
}

