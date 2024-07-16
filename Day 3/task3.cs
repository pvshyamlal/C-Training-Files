using System;
class task3{
	static void Main(String[] args){
		Console.WriteLine("Enter a String Value :");
		String s1=Console.ReadLine();
        Console.WriteLine(s1 +" is a: "+s1.GetType());
		double d=Convert.ToDouble(s1);
		Console.WriteLine("Double value :"+d);
		Console.WriteLine(d+" is: "+d.GetType());
		//decimal d1=Convert.ToDecimal(s1);
		//Console.WriteLine("Decimal value :"+d1);
		//Console.WriteLine(d1+" is a: "+d1.GetType());
	}
} 
