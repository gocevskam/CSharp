using System;

    class TrapezoidArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
           
            double s = 0;
           
                s = ((a + b) / 2) * h;
                Console.WriteLine("The trapezoid area is: {0}", s);
           
        }
    }

