using System;
class S10{
    static void Main(string[] args){
    try{
        int a = 10;
        Console.WriteLine("Enter b value: ");
        int b = Convert.ToInt32( Console.ReadLine() );
        int c = a/b;
        Console.WriteLine(c);
    }
    catch(DivideByZeroException e){
        Console.WriteLine(e.Message);
    }

    Console.WriteLine("bye");
}
}