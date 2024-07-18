using System;
using System.Threading;
class Animal{
    static void Dog(int n){
        for (int i=0;i<n;i++){
            Console.WriteLine("Dog is running lap"+i);
            Console.WriteLine("Dog is Sleeping");
        }
        Console.WriteLine("Dog Finished Running");
    }
    static void Cat(int n){
        for (int i=0;i<n;i++){
            Console.WriteLine("Cat is running lap"+i);
            Console.WriteLine("Cat is Sleeping");
        }
        Console.WriteLine("Cat Finished Running");
    }
    static void Main(){
        Thread t1 = new Thread(() => Dog(5));
        Thread t2 = new Thread(() => Cat(3));
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
    }
}