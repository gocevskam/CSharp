using System;

    class SurficeOfTriangle
    {
        public static void SideAndAltitude()
        {
            Console.WriteLine("Enter a side:");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a altitude:");
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("S = {0}", side * altitude / 2);

        }
        public static void ThreeSides()
        {
            Console.WriteLine("Enter a first side:");
            double sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second side:");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third side:");
            double sideThree = double.Parse(Console.ReadLine());
            double s = (sideOne + sideTwo + sideThree) / 2;
            Console.WriteLine("S = {0}", Math.Sqrt(s * (s - sideOne) * (s - sideTwo) * (s - sideThree)));
        }
        private static void TwoSidesAndAngle()
        {
            Console.WriteLine("Enter a first side:");
            double sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second side:");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an angle:");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("S = {0}", sideOne * sideTwo * Math.Sin(Math.PI * angle / 180) / 2);
        }


        static void Main()
        {
            Console.WriteLine("Enter how you will calculate the surfice of triangle:");
            Console.WriteLine("1 - Side and an altitude to it;\n2 - Three sides;\n3 - Two sides and an angle between them. ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: SideAndAltitude();
                    break;
                case 2: ThreeSides();
                    break;
                case 3: TwoSidesAndAngle();
                    break;
                default: Console.WriteLine("Incorrect input!");
                    break;
            }
        }
    }

