using System;

class Demo{
    public delegate int show(int a, int b, int c);
    public static int display(int a, int b, int c){
        return (a+b+c);
    }
    static void Main(string[] args){
        show obj = display;
        Console.WriteLine(obj(10,20,30));
    }
        
}