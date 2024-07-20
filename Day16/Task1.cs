/*
The store manager to input new fruits into the system. The program then displays the 
list of fruits entered, providing a simple way to keep track of the available fruits 
in the store's inventory. This basic system could be expanded to include more features
 like quantity tracking of fruits, etc.
*/

using System;
using System.Collections.Generic;
class Task1
{
    static void Main()
    {
        List<string> fruits = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter a fruit (or 'x' to exit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "x")
                break;
            fruits.Add(input);
        }
        Console.WriteLine("List of fruits entered:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}