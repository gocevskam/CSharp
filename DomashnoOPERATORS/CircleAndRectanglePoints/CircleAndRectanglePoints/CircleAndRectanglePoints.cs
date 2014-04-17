using System;

class CircleAndRectanglePoints
{
    static void Main()
    {
        Console.WriteLine("write a point with x and y:");
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        bool inTheCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
        bool inTheRectangle = ((x > (-1)) && (x < 5)) && ((y < 1) && (y > (-1)));


        if (inTheCircle)
        {
            if (!inTheRectangle)
                Console.WriteLine("The point is in the circle and out of the rectangle");
        }
            else 
        {
            Console.WriteLine("The point isn't in the circle and out of the rectangle");
        }
    }
}

