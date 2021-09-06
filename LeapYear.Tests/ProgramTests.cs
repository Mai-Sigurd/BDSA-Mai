using System;
using Xunit;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void divisble_by_four()
        {
            Assert.True(Program.isLeapYear(2004));
            Assert.False(Program.isLeapYear(1999));
        }

        [Fact]
        public void centurial_leap_years()
        {
            Assert.True(Program.isLeapYear(2000));
            Assert.False(Program.isLeapYear(1900));
        }
    }
}
