/*
Birthday Celebration Event

Imagine you're organizing a community event to celebrate the birthdays of individuals in a retirement community or a neighborhood. You've created a program to gather the names and ages of the attendees and simulate a birthday celebration for each person present.



User Interaction:

The program starts by prompting the organizer to input the number of people attending the event.
For each attendee, the organizer enters their name and age.
After all the details are entered, the program simulates a birthday celebration for each person by incrementing their age and displaying a message about the celebration.
The celebration event proceeds with other planned activities after everyone's birthdays are acknowledged.
The program allows the organizer to collect the names and ages of attendees for a birthday celebration event. It simulates the celebration by incrementing each person's age and acknowledging their birthday within the program. 

Sample Test Case:

Enter the number of people:
2
Enter name for person 1:
rekha
Enter age for person 1:
45
Enter name for person 2:
lekha
Enter age for person 2:
55
Celebrating Birthdays:
rekha is celebrating their birthday! They are now 46 years old.
lekha is celebrating their birthday! They are now 56 years old.
*/

using System;
class Task2
{
    static void Main()
    {
        Console.WriteLine("Enter the number of people:");
        int numberOfPeople = int.Parse(Console.ReadLine());

        string[] names = new string[numberOfPeople];
        int[] ages = new int[numberOfPeople];

        for (int i = 0; i <numberOfPeople; i++)
        {
            Console.WriteLine("Enter name for person "+(i+1) );
            names[i] = Console.ReadLine();

            Console.WriteLine("Enter age for person "+(i+1) );
            ages[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Celebrating Birthdays:");

        for (int i = 0; i < numberOfPeople; i++)
        {
            ages[i]++;
            Console.WriteLine(names[i]+" is celebrating their birthday! They are now "+ages[i]+" years old.");
        }
    }
}