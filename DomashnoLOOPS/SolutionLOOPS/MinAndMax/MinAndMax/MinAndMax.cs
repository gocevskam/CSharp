using System;

    class MinAndMax
    {
        static void Main()
        {
           
            Console.WriteLine("enter how many numbers you'd like to enter:");
            int n = int.Parse(Console.ReadLine());
            int number=0;
            Console.WriteLine("enter number:");
            int number1 = int.Parse(Console.ReadLine());
            int min = number1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter number:");
                number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
            }
            int max = number1;
            for (int i = 0; i < n; i++)
            {
                if (number > max)
                {
                    max = number;
                }
            }
           
            Console.WriteLine("The minimum of those numbers is:{0}",min);
            Console.WriteLine("The maximum of those numbers is: {0}",max);
        }
    }

