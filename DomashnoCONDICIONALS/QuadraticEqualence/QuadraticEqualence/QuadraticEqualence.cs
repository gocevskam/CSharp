using System;

    class QuadraticEqualence
    {
        static void Main()
        {
            Console.Write("enter the coeficient a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter the coeficient b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter the coeficient c=");
            int c = int.Parse(Console.ReadLine());
            double x;
            double x1, x2;

            double d = Math.Sqrt((b*b)-(4*a*c));
            if (d == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("the quadratic equation has one result={0}", x);
            }
            else if (d > 0)
            {
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("the results are x1={0} and x2={1}", x1, x2);
            }
            else
            {
                Console.WriteLine("the quadratic equation does not have real number as result");
            }

            Console.WriteLine(d);
        }
        
    }
