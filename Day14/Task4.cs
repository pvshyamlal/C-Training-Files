using System;
using System.Collections.Generic;
class Task4
{
    static void Main()
    {
        List<string> studentNm = new List<string> { "sandeep", "lal", "dinesh", "koti", "bob" };
        studentNm.Insert(2, "Prasanth");
        List<string> extraNm = new List<string> { "vijay", "harsha","arora"};
        studentNm.AddRange(extraNm);
        studentNm.Sort();
        studentNm.Reverse();
        foreach (string name in studentNm)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            string revName = new string(charArray);
            bool isPalindrome = name.Equals(revName);
            Console.WriteLine(name + " is" + (isPalindrome ? "" : " not") + " a palindrome.");
        }
    }
}k