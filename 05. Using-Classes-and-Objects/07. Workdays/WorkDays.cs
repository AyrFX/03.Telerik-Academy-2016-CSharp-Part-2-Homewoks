using System;

class WorkDays
{
    static void Main()
    {
        DateTime futureDate = DateTime.Parse(Console.ReadLine());
        DateTime[] holidays = new DateTime[10];

        DateTime today = DateTime.Today;
        int workDays = 0;
        while (today <= futureDate)
        {
            if (today.DayOfWeek == DayOfWeek.Monday ||
                today.DayOfWeek == DayOfWeek.Tuesday ||
                today.DayOfWeek == DayOfWeek.Wednesday ||
                today.DayOfWeek == DayOfWeek.Thursday ||
                today.DayOfWeek == DayOfWeek.Friday)
            {
                if (Array.IndexOf(holidays, today) == -1)
                {
                    workDays++;
                }
            }
            today.AddDays(1);
        }
    }
}