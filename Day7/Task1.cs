/*Vehicle Information System : Consider you are working in a manufacturing company where you are required to create an abstract class Vehicle with an abstract method description. Also, define the method in Category class which returns you the information of the vehicle as below:
Command line args 2 bike
The number of wheels in a bike are 2
Note : The description method should accept two parameters where the first parameter is of type int and second of type String*/
using System;
class Task1{
    static void Main(string[] args){
        string num = args[1];
        //parse the string to integer
        int number = Int32.Parse(num);
        string vehicle = args[0];
        Console.WriteLine("The number of wheels in a "+vehicle+" are "+num);
    }
}
