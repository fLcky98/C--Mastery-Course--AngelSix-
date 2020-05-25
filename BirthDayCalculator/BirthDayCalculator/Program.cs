using System;
using System.Globalization;

namespace BirthDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVariable = 0;
            while (myVariable < 10)
            {
                Console.WriteLine("Hi!");
                myVariable++;
            }

            IntroduceSavvy();
            var usersDateOfBirth = AskForDateOfBirth();

        }

        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy. I'm really good at guessing the week you were born on.");
        }



        /// <summary>
        /// This method is used to ask the user for a date. The method then checks if the given input is a valid date
        /// If the date is invalid, the method informs the user and trys again.
        /// 
        /// When the date is valid, the date is returned.
        /// </summary>

        public static DateTimeOffset AskForDateOfBirth()
        {

            // Create variable with initial out of range value
            var dateOfBirth = DateTimeOffset.MaxValue();

            // Until the checked date is greater than today's date...
            while (dateOfBirth > DateTimeOffset.Now)
            {
                // Tell the user to provide a date
                Console.WriteLine($"Could you please provide me with your date of birth? {CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                // Reads and stores the users response in the userText variable
                var userText = Console.ReadLine();

                // Check if the user entered a valid date
                if (DateTimeOffset.TryParse(userText, out var parsedDate))
                    // Set the checked date to users given date
                    dateOfBirth = parsedDate;
                // If the user provided an invalid date..
                else
                    // Inform the user, the date is invalid 
                    Console.WriteLine("you did not enter a valid date");
            }
            // Return the result
            return dateOfBirth;
        }
    }
}
