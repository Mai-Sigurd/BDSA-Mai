using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            leapYearProgram();
        }

        public static void leapYearProgram()
        {
            printLeapYear(getUserInput());
        }

        public static int getUserInput()
        {
            var userInput = Console.ReadLine();
            int intVal = Convert.ToInt32(userInput);
            return intVal;
        }

        public static void printLeapYear(int year)
        {
            string statement = new string("");
            if (isLeapYear(year))
            {
                statement = "yay";
            }
            else
            {
                statement = "nay";
            }
            Console.WriteLine(statement);
        }
        public static bool isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                else return true;
            }
            else return false;
        }


    }
}
