using System;

    class QuardaticEquation
    {
        static void Main()
        {
            Console.WriteLine("Please insert the first coefficient of the quardatic equation:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the secound coefficient of the quardatic equation:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the free coefficient of the quardatic equation:");
            double c = double.Parse(Console.ReadLine());
            double x1 = (-b + Math.Sqrt((b*b)-4*a*c))/ (2* a);
            double x2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            Console.WriteLine("The results are {0} and {1}.", x1, x2);
            

        }
    }

