using System;
using Xunit;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        Program program = new Program();
        [Fact]
        public void divisble_by_four()
        {
            
            Assert.True(program.isLeapYear(2004));
            Assert.False(program.isLeapYear(1999));
        }

        [Fact]
        public void centurial_leap_years()
        {
            Assert.True(program.isLeapYear(2000));
            Assert.False(program.isLeapYear(1900));
        }
    }
}
