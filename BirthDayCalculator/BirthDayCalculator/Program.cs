using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;

namespace BirthDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduce our Savvy robot
            IntroduceSavvy();

            // Ask the user for their date of birth
            var usersDateOfBirth = AskForDateOfBirth();

            // Announce date of birth information
            AnnounceDateOfBirthInformation(usersDateOfBirth);
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
            var dateOfBirth = DateTimeOffset.MaxValue;

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

        /// <summary>
        /// Display Information to the user about the given date of birth
        /// </summary>
        /// <param name="date">The date of birth to display information about</param>
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            // Store current time
            var now = DateTimeOffset.UtcNow;
            // Display date of birth
            Console.WriteLine($"So you were born on {date:dd MMM yyyy}");

            // Display the day of the week of birth
            Console.WriteLine($"That was a {date.DayOfWeek}");

            // Indicate if we have already passed the user date of birth
            // For the current year
            var hasPassedBirthDay = now.DayOfYear > date.DayOfYear;

            // Get a day representing the users next birthday

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthDay ? 1 : 0), date.Month, date.Day, 0, 0, 0, TimeSpan.Zero);

            // Display how many days until the users next birthday!
            Console.WriteLine($"It is { (nextBirthday - now).TotalDays:0} days until your next birthday");

            // Get the users age
            var userAge = now.Year - date.Year - (hasPassedBirthDay ? 0 : 1);

            // Display users age
            Console.WriteLine($"And you are {userAge} years old!");

            // Display users age in dog years
            Console.WriteLine($"You are {userAge * 7 } in dog years!");

            // Get users time alive
            var timeAlive = now - date;

            // Display how long the users have been alive in days
            Console.WriteLine($"You are {timeAlive.TotalDays:n0} days old");

            // Display how long the users have been alive in hours
            Console.WriteLine($"You are {timeAlive.TotalHours:n0} hours old");

            // Display how long the users have been alive in seconds
            Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");
        }
    }
}