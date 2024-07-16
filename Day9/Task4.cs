/*
In many applications, there are certain values that don’t change once they are assigned. 
Observe the equation below and decide which needs to be specified as a final and print 
the result as shown in sample test cases.

Equation: x*y + 45 + 3.14*z . Do not use 45 and 3.14 directly in order to calculate the 
result. Store them in a final variable.

Note : Take x,y from user which are integers and z as double
Sample test case:
Command line args 2 3 5.2
The result is 67.328
*/
using System;
public class Task4{
    static void Main(string[] args){
        int x = int.Parse(args[0]);
        int y = int.Parse(args[1]);
        double z = double.Parse(args[2]);
        const int constant1 = 45;
        const double constant2 = 3.14;
        double result = x * y + constant1 + constant2 * z;
        Console.WriteLine("The result is " + result);
    }
}
