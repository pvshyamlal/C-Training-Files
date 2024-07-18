/*
You are a software engineer and you need to implement a method that takes a array of 
integers and returns a new list that contains only the even numbers. 
*/

using System;
using System.Collections.ObjectModel;
class Task1{
    public static void Main(string[] args){
        Collection<string> mycall = new Collection<string>();
        mycall.Add("Hello");
        mycall.Add("Hi:");
        mycall.Add("Hey");
        string[] s1 = new string[mycall.Count];
        mycall.CopyTo(s1,0); // s1 = {"Hello", "Hi:", "Hey"}
        Console.WriteLine(s1[0]);
    }
}
