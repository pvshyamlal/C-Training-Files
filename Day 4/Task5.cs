using System;
class Task5{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());
        int sum = 0, prod = 1, rev=0;
        while(num !=0){
            int temp = num%10;
            num = num/10;
            sum +=temp;
            prod *= temp;
            rev = rev*10 + temp;
        }
        Console.WriteLine("sum of the given number is: "+sum);
        Console.WriteLine("product of the given number is: "+prod);
        if (sum == prod){
            Console.WriteLine("it is a spy number");
            Console.WriteLine("Given number in reverse order: "+ rev);
        }
        else{
            Console.WriteLine("it is not a spy number");
        }
    }
}