using System;

namespace WeekdayFinderNamespace
{
  public class WeekdayFinder
  {
    public static string GetDayOfWeekFromDate(string date)
    {
      string[] dateStrings = date.Split("/");
      int[] dateInts = Array.ConvertAll(dateStrings, s => int.Parse(s));
      int year = dateInts[2];
      int month = dateInts[0];
      int day = dateInts[1];
      DateTime dateObject = new DateTime(year, month, day);
      return dateObject.DayOfWeek.ToString();
    }
  }
}
