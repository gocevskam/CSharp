using System;

    class intDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("enter 0 for integer,1 for double or 2 for string:");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 0: Console.WriteLine("integer");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("the value increased with 1 is: {0}", intNumber + 1);
                    break;
                case 1: Console.WriteLine("double");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("the double value increased with 1 is: {0}", doubleNumber + 1);
                    break;
                case 2: Console.WriteLine("string");
                    string variable = Console.ReadLine();
                    Console.WriteLine("the string appended with *: {0}",variable + "*");
                    break;
                default: Console.WriteLine("invalid input!");
                    break;
            }
        }
    }

