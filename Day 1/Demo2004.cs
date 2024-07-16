using System;
namespace App1{
	class Sample{
		public static void display(){
			Console.WriteLine("Welcome to .NET ");
		}
	}
}
namespace App2{
	class Demo2004{
		static void Main(String[] args){
			Console.WriteLine("Welcome to C#");
			
			App1.Sample.display();
		}
	}
}