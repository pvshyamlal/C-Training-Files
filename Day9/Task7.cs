/*Ravi wants to create a toy for kids that speaks in the voice of the animal when its 
image is clicked. Ravi's modifications made the animal's name appear(String),when the 
image is clicked.

Create a program which takes that name and displays the corresponding statement.

Sample Test Case:(Observe and match other test case statements)

Command line args dog
The dog barks.*/

using System;
class Task7{
    static void Main(string[] args){
        string animalName = args[0].ToLower();
        switch (animalName){
            case "dog":
                Console.WriteLine("The dog barks.");
                break;
            case "cat":
                Console.WriteLine("The cat meows.");
                break;
            case "cow":
                Console.WriteLine("The cow moos.");
                break;
            default:
                Console.WriteLine("Unknown animal.");
                break;
            
        }
    }
}