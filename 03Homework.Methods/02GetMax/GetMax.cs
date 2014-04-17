using System;

    class GetMaxOfInt 
    {
        static int GetMax(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

        static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            int firstNum = int.Parse(Console.ReadLine());
            int secoundNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is:");
            Console.WriteLine(GetMax(GetMax(firstNum, secoundNum), thirdNum));
        }
    }
