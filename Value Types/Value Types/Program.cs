using System;

namespace Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Integral types    // Range                                                    // Size                         // .NET Type
            sbyte mySByte;      // -128 to 127                                              // Signed 8-bit Integer         // System.SByte
            byte myByte;        // 0 to 255                                                 // Unsigned 8-bit Integer       // System.Byte
            short myShort;      // -32,768 to 32,767                                        // Signed 16-bit Integer        // System.Int16
            ushort myUShort;    // 0 to 65,535                                              // Unsigned 16-bit Integer      // System.UInt16
            int myInt;          //  -2,147,483,648 to 2,147,483,647                         // Signed 32-bit Integer        // System.Int32
            uint myUInt;        // 0 to 4,294,967,295                                       // Unsigned 32-bit Integer      // System.UInt32
            long myLong;        // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  // Signed 64-bit Integer        // System.Int64
            ulong myULong;      // 0 to 18,446,744,073,709,551,615                          // Unsigned 64-bit Integer      // System.UInt64

            // Combinations of 0 and 1 in any order of a 2-bit system will have range of 4: 00 01 10 11
            // sbyte is an 8-bit and has 8 (0 and 1's): 00000000 00000001 00000010 00000011 00000100 00000101 ....

            // Signed means negative numbers are possible. Byte is the only one defined by SByte as signed where as the rest use the U. U as in UNsigned, meaning negative numbers are unavailable).
            //Examples

            // A signed integer has the range of  -2,147,483,648 to 2,147,483,647. Meaning -1 is a possible signed integer.
            // int = -1;

            // An Unsigned Integer doesn't have the range of negative numbers. -1 is therefore not possible. 
            // uint = -1;

            //Cant be signed as the range of a byte is 0-255
            // byte = 256;
                
            //FLOATING POINT NUMBERS


            // there are 3 types of floating point numbers:

            float myFloat; // Approximately 6-9 digits (32 bits / 4 bytes)
            double myDouble; // Approximately 15-17 digits (64 bits / 8 bytes)
            decimal myDecimal; // Approximately 28-29 digits (128 bits / 16 bytes)

            myFloat = 1.000001f;
            Console.WriteLine(myFloat);

            myFloat = 11111115111.05f;
            Console.WriteLine($"{myFloat:F10}");
            // The 3 important simple types

            bool myBool;
            char myChar;
            string myString; // a collection or array of char(acters)

            //Outputs the size of a boolean in bytes and then bits
            Console.WriteLine($"A boolean is {sizeof(bool)} bytes");
            Console.WriteLine($"A boolean is {sizeof(bool) * 8} bits");

            //Ouputs the size of an integer in bytes and then bits
            Console.WriteLine($"An Integer is {sizeof(int)} bytes");
            Console.WriteLine($"An Integer is {sizeof(int) * 8} bits");

            myChar = 'a'; //Observe the single quotes! NOT DOUBLE QUOTES


            //OTHER TYPES
            DateTime myDate;
            TimeSpan myTime;


            //  Options for storing information
            //  
            //  1. Whole numbers
            //  2. Floating point numbers
            //  3. Truth values
            //  4. Text (char/string)
            //


        }
    }
}
