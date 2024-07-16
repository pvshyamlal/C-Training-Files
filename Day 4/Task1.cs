using System;
class Task1
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
 
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
 
        Console.WriteLine("Hello, "+name +"!");
        Console.WriteLine("You are "+age+" years old.");
        Console.WriteLine("You were born in the year "+(2024 - age)+".");
 
        if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age <= 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }
    }
}