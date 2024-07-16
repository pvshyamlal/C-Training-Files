using System;
namespace N1{
	class Demo2{
		public void display(){
			Console.WriteLine("Hiii");
		}
	}
	class Demo3{
		public static void Main(String[] args){
			Console.WriteLine("Hello");
			Demo2 d1=new Demo2();
			d1.display();
		}
	}
}