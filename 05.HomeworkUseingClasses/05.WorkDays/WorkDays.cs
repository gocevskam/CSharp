using System;

class WorkDays
{
    static void Main()
    {
        Console.WriteLine("Enter the date YYYY/MM/DD");
        DateTime final = DateTime.Parse(Console.ReadLine());

        DateTime startDay = DateTime.Today;

        int timeLen = Math.Abs((startDay - final).Days);

        Console.WriteLine(CountWorkDays(startDay, final, timeLen));

    }

    static DateTime[] Holidays()
    {
        DateTime[] holiday = new DateTime[]{
        new DateTime(2013, 01, 01),
        new DateTime(2013, 02, 23),
        new DateTime(2013, 03, 30),
        new DateTime(2013, 05, 6),
        };
        return holiday;
    }


   static int CountWorkDays(DateTime todaysDate, DateTime endDate, int len)
   {
       bool isPublicHoliday = false;
        int totalWorkDays = 0; 
        for (int i = 0; i < len; i++)
        {
            todaysDate = todaysDate.AddDays(1);
            if ((todaysDate.DayOfWeek != DayOfWeek.Saturday) && (todaysDate.DayOfWeek != DayOfWeek.Sunday))
            {
                for (int j = 0; j < Holidays().Length; j++)
                {
                    if (todaysDate == Holidays()[j])
                    {
                        isPublicHoliday = true;
                        break;
                    }
                }
                if (!isPublicHoliday)
                {
                    totalWorkDays++;
                }
                isPublicHoliday = false;
            }
        }
        return totalWorkDays;

    }
}


