using System;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declaring variable and assigning value
            int counter = 5;

            //Output the value of counter
            Console.WriteLine("Counter: " + counter);

            //Change value of counter to 7
            counter = 7;

            //Output the value of counter
            Console.WriteLine("Counter: " + counter);


            //Increment value of counter by 1 (++ = increment operator) (counter++ is the same as: counter = counter + 1) 
            counter++;

            //Output the value of counter
            Console.WriteLine("Counter: " + counter);

            //Same works for minus
            counter--;

            //Output the value of counter
            Console.WriteLine("Counter: " + counter);

        }

    }
}
