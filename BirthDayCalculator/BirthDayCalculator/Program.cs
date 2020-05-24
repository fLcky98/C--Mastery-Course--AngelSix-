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
            var a = 0;
            var b = false;
            var c = DateTimeOffset.MinValue;

            Test(a, b, c);
        }

        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy. I'm really good at guessing the week you were born on.");
        }

        public static DateTimeOffset AskForDateOfBirth()
        {
            Console.WriteLine($"Could you please provide me with your date of birth? {CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

            var userText = Console.ReadLine();
            var parsedDate = DateTimeOffset.MinValue;

            var succeeded = DateTimeOffset.TryParse(userText, out parsedDate);

            if (succeeded == false)
            {
                Console.WriteLine("Hmm.. That doesn't seem right!");

                return DateTimeOffset.Now;
            }

            return parsedDate;
 
        }
        public static void Test(int a, bool b, DateTimeOffset c)
        {
            a = 5;
            b = true;
            c = DateTimeOffset.UtcNow;
        }
    }
}
