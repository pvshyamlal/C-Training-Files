using System;
abstract class Test{
    protected abstract void show();
}
class Test1:Test{
    protected override void show(){
        Console.WriteLine("Hello World");
    }
    public static void Main(string[] args){
        Test1 t=new Test1();
        t.show();
    }
}