using System;

    class BiggestOfFive
    {
        static void Main()
        {
            Console.Write("enter a number a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter a number b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter a number c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("enter a number d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("enter a number e=");
            int e = int.Parse(Console.ReadLine());
            int biggestNumber = a;

            if (biggestNumber < b)
            {
                biggestNumber = b;
            }
            if (biggestNumber < c)
            {
                biggestNumber = c;
            }
            if (biggestNumber < d)
            {
                biggestNumber = d;
            }
            if (biggestNumber < e)
            {
                biggestNumber = e;
            }
            Console.WriteLine("the biggest number is {0}",biggestNumber);
            
        }
    }

