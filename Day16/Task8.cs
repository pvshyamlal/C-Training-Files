/*
Ram is developing a program in Java to manage a list of tasks for his daily activities. He decides to create a Java class named ListOperations to handle the operations on his list using ArrayList.
When Ram runs the program, it asks him to input the number of elements he wants to add to the list.

Sample Test Case-1
Enter the number of elements you want to add:
3
Enter elements:
23
43
45
Elements in the list:
23
43
45

Sample Test Case-2
Enter the number of elements you want to add:
5
Enter elements:
76
65
I
56.9
codetantra
Elements in the list:
76
65
I
56.9
codetantra
*/

using System;
using System.Collections.Generic;
class Task8{
    static void Main(){
        Console.WriteLine("Enter the number of elements you want to add:");
        int count = Convert.ToInt32(Console.ReadLine());
        List<object> elements = new List<object>();
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < count; i++){
            object element = Console.ReadLine();
            elements.Add(element);
        }
        Console.WriteLine("Elements in the list:");
        foreach (object element in elements){
            Console.WriteLine(element);
        }
    }
}
