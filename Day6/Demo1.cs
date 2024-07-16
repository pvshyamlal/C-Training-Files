using System;
namespace Sample{
    public class Test1{
        public void Add(){
            Console.WriteLine("Hello!");
        }
    }
}
namespace Sample2{
    public class Test2{
        static void Main(string[] args){
            Sample.Test1 t1=new Sample.Test1();
            t1.Add();
        }
}
}

//Run csc Test1.cs Test2.cs