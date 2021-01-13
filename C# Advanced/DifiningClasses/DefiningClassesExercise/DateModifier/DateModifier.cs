using System;
using System.Linq;

namespace DefiningClasses
{
    public class DateModifier
    {
        // private int year;
        // private int month;
        // private int day;
        // 
        // public DateModifier(int year, int month, int day)
        // {
        //     Year = year;
        //     Month = month;
        //     Day = day;
        // }
        // 
        // public int Year
        // {
        //     get { return year; }
        //     set { year = value; }
        // }
        // 
        // public int Month
        // {
        //     get { return month; }
        //     set { month = value; }
        // }
        // 
        // public int Day
        // {
        //     get { return day; }
        //     set { day = value; }
        // }

        public static double CalculateDaysBetween(string firstDates, string secondDates)
        {
            double result = 0;

            int[] inputFirstDate = firstDates
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstDateYear = inputFirstDate[0];
            int firstDateMonth = inputFirstDate[1];
            int firstDateDay = inputFirstDate[2];

            int[] inputSecondDate = secondDates
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int secondDateYear = inputSecondDate[0];
            int secondDateMonth = inputSecondDate[1];
            int secondDateDay = inputSecondDate[2];

            DateTime startDate = new DateTime(firstDateYear, firstDateMonth, firstDateDay);
            DateTime endDate = new DateTime(secondDateYear, secondDateMonth, secondDateDay);

            // DateModifier firstDate = new DateModifier(firstDateYear, firstDateMonth, firstDateDay);
            // DateModifier secondDate = new DateModifier(secondDateYear, secondDateMonth, secondDateDay);

            result = Math.Abs((endDate.Date - startDate.Date).TotalDays);

            return result;
        }

    }
}
