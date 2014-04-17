using System;

    class CircleAreaAndPerimetar
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of the circle:");
            int r = int.Parse(Console.ReadLine());
            double area = (r * r) * Math.PI;
            double perimetar = 2 * r * Math.PI;
            Console.WriteLine("the area is {0} and the perimetar is {1}",area,perimetar);
        }
    }

