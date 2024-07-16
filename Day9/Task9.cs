/*
Imagine you are developing a software application for a bank. The application needs to 
process transactions which are initially entered as strings. The ParseIntExample class 
represents a module in this application that attempts to parse these strings into integers 
for further processing.

Create a Java program that attempts to convert a string to an integer using 
Integer.parseInt() and handles a NumberFormatException if the string is not a valid 
integer.
Sample Output:1

Parsed integer: 123456789
Sample Output:2

Enter an integer as a string: code
Error: The input is not a valid integer.*/

using System;
class Task9
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter an integer as a string:");
            string input = Console.ReadLine();

            int number = int.Parse(input);
            Console.WriteLine(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The input is not a valid integer.");
        }
    }
}