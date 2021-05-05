using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WeekdayFinderNamespace.Test
{
  [TestClass]
  public class WeekdayFinderTests
  {
    [TestMethod]
    public void WeekdayFinder_Today_Wednesday()
    {
      string today = "5/5/2021";
      string dayOfWeek = WeekdayFinder.GetDayOfWeekFromDate(today);
      Assert.AreEqual("Wednesday", dayOfWeek);
    }
  }
}
