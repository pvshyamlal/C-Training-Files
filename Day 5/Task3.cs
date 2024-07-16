using System;
class Task3{
    static void Main(string[] args){
        int flag=1;
        int num = int.Parse(Console.ReadLine());
        while(flag<num){
            flag*=2;
            if(flag == num){
                Console.WriteLine("True");
            }
        }
        if(flag!=num){
            Console.WriteLine("False");
        }
    }
}