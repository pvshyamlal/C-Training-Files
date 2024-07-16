using System;
namespace App{
public class Demo1{
  public void Main(){
    Console.WriteLine("hai How are you?");
}
}
public class Demo2{
  public void Main(){
   Console.WriteLine("hello! I am Fine");
}
}
public class Demo{
	public static void Main(string[] args){
		Demo1 d1=new Demo1();
		Demo2 d2=new Demo2();
		d1.Main();
		d2.Main();
		Console.WriteLine("GEC");
}
}
}