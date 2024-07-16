/*
Note: Final variable cannot be reassigned but can be used with other variables
Sample Test Case:
Command line args 4.585
Final number is: 4.585
Final number multiplied with 2: 9.17
Final number added with 4: 8.585
*/
using System;
sealed class Task1{
    static void Main(string[] args){
        double num = double.Parse(args[0]);
        Console.WriteLine("Command line args "+num);
        Console.WriteLine("Final number is: "+num);
        Console.WriteLine("Final number multiplied with 2: "+(num*2));
        Console.WriteLine("Final number added with 4: "+(num+4));
    }
}
