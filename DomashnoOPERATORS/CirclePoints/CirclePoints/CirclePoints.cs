using System;
  class CirclePoints
    {
        static void Main()
        {
            int x = 3;
            int y = 4;
            int r = 5;
            if ((x * x + y * y ) <= (r * r))
            {

                Console.WriteLine("The point is inside the circle.");
            }
            else
            {

                Console.WriteLine("The point isn't inside the circle.");
            }

        }
    }

