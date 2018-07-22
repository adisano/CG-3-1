using System;

namespace MonthNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number corresponding to a month of the year:");
            string monthInput = Console.ReadLine();
            string monthOutput = "";

            if (monthInput == "1")
            {
                monthOutput = "January";
            }
            else if (monthInput == "2")
            {
                monthOutput = "February";
            }
            else if (monthInput == "3")
            {
                monthOutput = "March";
            }
            else if (monthInput == "4")
            {
                monthOutput = "April";
            }
            else if (monthInput == "5")
            {
                monthOutput = "May";
            }
            else if (monthInput == "6")
            {
                monthOutput = "June";
            }
            else if (monthInput == "7")
            {
                monthOutput = "July";
            }
            else if (monthInput == "8")
            {
                monthOutput = "August";
            }
            else if (monthInput == "9")
            {
                monthOutput = "September";
            }
            else if (monthInput == "10")
            {
                monthOutput = "October";
            }
            else if (monthInput == "11")
            {
                monthOutput = "November";
            }
            else if (monthInput == "12")
            {
                monthOutput = "December";
            }
            else
            {
                monthOutput = "no known month of the year";
            }

            Console.WriteLine("You input a number corresponding to {0}.", monthOutput);
            Console.ReadLine();

        }
    }
}
