using System;
using System.Threading;

class Animal{
    static void dog(int n){
        for(int i = 0;i<n;i++){
            Console.WriteLine("Dog is running"+i);
        }
        Console.WriteLine("dog fininshed running");
    }

    static void cat(int n){
        for(int i = 0;i<n;i++){
            Console.WriteLine("Cat is sleeping"+i);
        }
    }
}