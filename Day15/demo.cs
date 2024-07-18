using System;
using System.Collections.ObjectModel;
class demo{
    public static void Main(string[] args){
        Collection<string> mycall = new Collection<string>();
        mycall.Add("Hello");
        mycall.Add("Hi:");
        mycall.Add("Hey");
        string[] s1 = new string[mycall.Count];
        mycall.CopyTo(s1,0); // s1 = {"Hello", "Hi:", "Hey"}
        Console.WriteLine(s1[0]);
        mycall.Insert(1, "Hola");
        mycall.Remove("Hey");
        foreach (string greeting in mycall)
        {
            Console.WriteLine(greeting);
        }
    }
}