/*
+You are a librarian and you need to find a specific book in a shelf of books. 
The books are arranged in alphabetical order by title. You have a list of book titles 
and you need to find the index of a specific book title in the list.
 
*/

using System;
using System.Collections.Generic;
class Task2{
    static void Main(){
        List<string> titles = new List<string>{
            "Book A","Book B","Book C","Book D","Book E"
        };
        string target = "Book C";
        int index = titles.IndexOf(target);
        if (index != -1)
        {
            Console.WriteLine("The index of "+target+" is "+index);
        }
        else
        {
            Console.WriteLine(target+" was not found in the list.");
        }
    }
}