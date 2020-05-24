using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUserDateOfBirth("Peter Bækgaard"));
            Console.WriteLine("The returned age is " + GetUserAge(21) + " years old");
        }

        public static string GetUserDateOfBirth(string fullName)
        {
            return fullName + " was born on Tuesday";
        }

        public static int GetUserAge(int userAge)
        {
            return userAge;
        }
    }
}
