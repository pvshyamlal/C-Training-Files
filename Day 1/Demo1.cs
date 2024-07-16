using System;
namespace App1{
	class Sample{
		public void display(){
			Console.WriteLine("Welcome to .NET ");
		}
	}
}
namespace App2{
	class Demo1{
		static void Main(String[] args){
			Console.WriteLine("Welcome to C#");
			App1.Sample.display();
		}
	}