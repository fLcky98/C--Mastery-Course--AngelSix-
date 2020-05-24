using System;
using System.Globalization;

namespace BirthDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var usersDateOfBirth = AskForDateOfBirth();
            Console.WriteLine(usersDateOfBirth);
        }

        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy. I'm really good at guessing the week you were born on.");
        }

        public static DateTimeOffset AskForDateOfBirth()
        {
            Console.WriteLine("Could you please provide me with your date of birth? " + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);

            var userText = Console.ReadLine();

            return DateTimeOffset.Parse(userText);
        }
    }
}
