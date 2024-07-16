/*
Imagine that you are creating a toy robot to amuse kids that can shape clay into the 
desired shape.Write a code which enables robot to mould the shapeless clay into desired 
shape.
Sample Test Case:
Command line args: Traingle
Clay is shapeless
Clay is moulded into Traingle
note:use base
*/

using System;
public class Robot{
    public virtual void MoldClay(string shape){
        Console.WriteLine("Clay is shapeless");
        Console.WriteLine("Clay is moulded into "+shape);
    }
}
public class ToyRobot : Robot{
    public override void MoldClay(string shape){
        base.MoldClay(shape);
    }
}
public class Task6{
    public static void Main(string[] args){
        string shape = args[0];
        ToyRobot robot = new ToyRobot();
        robot.MoldClay(shape);
    }
}


