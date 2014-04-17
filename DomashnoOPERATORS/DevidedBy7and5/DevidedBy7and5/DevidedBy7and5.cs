using System;

    class DevidedBy7and5
    {
        static void Main()
        {
            Console.WriteLine("Insert a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a % 7 == 0) && (a % 5 == 0))
            {
                Console.WriteLine("Can be devided by 5 and 7");
            }
            else
            {
                Console.WriteLine("Can not be devided by both: 5 and 7");
            }
        }
    }

