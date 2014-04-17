using System;

    class ReadsYear
    {
        static void Main()
        {
            Console.WriteLine("Enter the year:");
            int yearNum = int.Parse(Console.ReadLine());
            DateTime year = new DateTime(yearNum);

            Console.WriteLine("Is {0} leap year: {1}", yearNum, DateTime.IsLeapYear(yearNum));
           
           
        }
    }

