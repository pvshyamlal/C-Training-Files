/*
The use of final with classes is to create an immutable class like predefined Math class. 
You are given a task to create a final class Science which has the static methods newton 
and einstein which print as follows:
Sample Input and Output:
Command line args 10 20
After applying Newton's law, force F = 200
After applying Einstein's law, Energy E = 4000
*/

using System;
public static class Science
{
    public static void Main(string[] args)
    {
        int mass = int.Parse(args[0]);
        int acceleration = int.Parse(args[1]);
        newton(mass, acceleration);
        einstein(mass, acceleration);
        }

    public static void newton(int mass, int acceleration)
    {
        int force = mass * acceleration;
        Console.WriteLine("After applying Newton's law, force F = " + force);
    }

    public static void einstein(int mass, int acceleration)
    {
        int energy = (acceleration * acceleration)*mass;
        Console.WriteLine("After applying Einstein's law, Energy E = " + energy);
    }
}
