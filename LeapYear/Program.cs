using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            startleapYearProgram(getUserInput());
        }

        public static void startleapYearProgram(string userInput)
        {
            if(validtor(userInput)){
                printLeapYear(Convert.ToInt32(userInput));
            }          
        }

        private static bool validtor(string userInput){
            try{
                int intVal = Convert.ToInt32(userInput);
                if(intVal < 1582){
                    Console.WriteLine("My guy, we need a year higher than 1581, run program again");
                    return false;
                }else return true;

            } catch (FormatException)
            {   
                Console.WriteLine("My guy, please write a number, run program again");
                return false;
            }
        }

        public static string getUserInput()
        {
            return Console.ReadLine();
            
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
