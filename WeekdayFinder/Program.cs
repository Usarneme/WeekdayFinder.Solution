using System;
using WeekdayFinderNamespace;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the Weekday Finder! You can enter any date and we will tell you what weekday that was.");
    Console.Write("Enter date (in the format MM/DD/YYYY): ");
    string inputDate = Console.ReadLine();
    // validator
    if (!inputDate.Contains("/"))
    {
      Console.WriteLine("You forgot your slashes. Please try again...");
      Main();
    }
    string[] dateStrings = inputDate.Split("/");
    if (dateStrings.Length != 3)
    {
      Console.WriteLine("You did not enter a full date in the right format. Please try again...");
      Main();
    }
    // pass to WeekdayFinder method...
    string dayOfWeek = WeekdayFinder.GetDayOfWeekFromDate(inputDate);
    Console.WriteLine("On {0} the day of the week is: {1}", inputDate, dayOfWeek);
  }
}