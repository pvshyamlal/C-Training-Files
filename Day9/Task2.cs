/*
Consider a scenario where we have a class Vehicle with a final method startEngine() . This method cannot be overridden in any subclass of Vehicle. 
Create the final method which takes a String parameter which shows the output in the below format
Sample Input and Output :
Command line args Bike
The Bike engine starts.
*/
using System;
public class Vehicle{
    // Virtual method that can be overridden
    public virtual void StartEngine(string vehicleType){
        Console.WriteLine("The " + vehicleType + " engine starts.");
    }
}
public class vehicleType : Vehicle{
    // Sealed method to prevent further overriding
    public sealed override void StartEngine(string vehicleType){
        base.StartEngine(vehicleType);
    }
}
public class Task2{
    public static void Main(string[] args){
            string vehicleType = args[0];
            vehicleType vehicle = new vehicleType();
            vehicle.StartEngine(vehicleType);
    }
}
