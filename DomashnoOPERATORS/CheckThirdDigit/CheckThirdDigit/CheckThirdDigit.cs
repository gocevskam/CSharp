using System;

    class CheckThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Insert a number:");

            int p = Convert.ToInt32(Console.ReadLine());
           
            int m = p % 1000;
            int n = m / 100;
            if (n == 7)
                Console.WriteLine("The third digit is: " + n);
            else
                Console.WriteLine("The third digit isn't 7");
            
            

            
        }
    }

