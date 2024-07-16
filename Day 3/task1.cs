using System;
class task1{
	static void Main(String[] args){
		Console.WriteLine("Enter an Integer :");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Integer value :"+a);
		Console.WriteLine(a.GetType());
		long b=a;
		Console.WriteLine("Long value :"+b);
		Console.WriteLine(b.GetType());
		float c=b;
		Console.WriteLine("Float value :"+c);
		Console.WriteLine(c.GetType());
		double d=c;
		Console.WriteLine("Double value :"+d);
		Console.WriteLine(d.GetType());
	}
}