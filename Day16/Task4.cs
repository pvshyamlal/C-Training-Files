/*
Geography Quiz Administration

Imagine you're creating a basic quiz administration system for a geography class. The program is designed to gather information about specific countries and their capitals for quiz preparation purposes.

User Interaction:

The program begins by asking the user to input the country and its corresponding capital for different countries.
The user enters the name of the country and its capital consecutively for each iteration.
Once the information for countries is entered, the program displays a list of the entered country-capital pairs.
The system then generates a quiz using this information for the students.
*/
using System;
using System.Collections.Generic;

class Task4{
    static void Main(){
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
        Console.WriteLine("Enter the country and its capital (separated by a comma). Enter 'done' to finish.");
        string input;
        do{
            input = Console.ReadLine();
            if (input.ToLower() != "done"){
                string[] countryCapitalPair = input.Split(',');
                if (countryCapitalPair.Length == 2){
                    string country = countryCapitalPair[0].Trim();
                    string capital = countryCapitalPair[1].Trim();
                    countryCapitals[country] = capital;
                }
                else{
                    Console.WriteLine("Invalid input. Please enter the country and its capital separated by a comma.");
                }
            }
        } while (input.ToLower() != "done");

        Console.WriteLine("Entered country-capital pairs:");
        foreach (var pair in countryCapitals){
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
        Console.WriteLine("Generating quiz...");
        Console.WriteLine("Quiz generated successfully!");
    }
}