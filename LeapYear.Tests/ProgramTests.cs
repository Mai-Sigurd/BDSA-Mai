using System;
using System.IO;
using Xunit;

namespace LeapYear.Tests
{
    public class ProgramTests
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

        [Fact]
        public void prints_yay()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.printLeapYear(1996);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("yay", output);
        }

        [Fact]
        public void prints_nay()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.printLeapYear(1800);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("nay", output);
        }

        [Fact]
        public void prints_need_number(){
             // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act
            Program.startleapYearProgram("hello");
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("My guy, please write a number, run program again", output);
            return;
        }

       [Fact]
       public void prints_need_higher_number(){
            // Arrange
           var writer = new StringWriter();
           Console.SetOut(writer);

           // Act
           Program.startleapYearProgram("1000");
           var output = writer.GetStringBuilder().ToString().Trim();

           // Assert
           Assert.Equal("My guy, we need a year higher than 1581, run program again", output);
           return;
       }
    }
}
