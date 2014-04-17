using System;

    class BonusScores
    {
        static void Main()
        {
            Console.WriteLine("enter a digit number:[1...9]");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1:
                case 2: 
                case 3: 
                    Console.WriteLine("the digit is between 1-3, and it is multiplied by 10: {0}", digit * 10);
                    break;
                case 4: 
                case 5: 
                case 6: 
                    Console.WriteLine("the digit is between 4-6, and it is multiplied by 100: {0}", digit * 100);
                    break;
                case 7: 
                case 8: 
                case 9: 
                    Console.WriteLine("the digit is between 7-9, and it is multiplied by 1000: {0}", digit * 1000);
                    break;
                default: Console.WriteLine("the input is not a digit");
                    break;

            }
        }
    }

