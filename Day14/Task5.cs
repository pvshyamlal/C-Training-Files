using System;
using System.Collections.Generic;
class Task5
{
    static void Main()
    {
        List<string> empNm = new List<string>
        {
            "Dinesh","Lal","Sandeep","Prasanth","Arya","Aacharya"
        };
        empNm.RemoveAll(name => name.StartsWith("A"));
        empNm.RemoveRange(0, 2);
        foreach (string name in empNm)
        {
            Console.WriteLine(name);
        }
    }
}