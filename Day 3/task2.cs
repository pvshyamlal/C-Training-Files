using System;
class task2{
	static void Main(String[] args){
		//Console.WriteLine("Enter the number: ");
        float a=56.478F;
        Console.WriteLine("After narrowing values are:");
        Console.WriteLine("Float value: "+a);
        long b = (long)(a);
        Console.WriteLine("Long value: "+b);
        int c = (int)(b);
        Console.WriteLine("Int value: "+c);
	}
}