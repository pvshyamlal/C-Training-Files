using System;
class Task4{
    static void Main(){
        Console.Write("Enter the end of the range: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Prime numbers up to {0}: ", end);
        for (int i = 2; i <= end; i++){
            bool flag = true;
            for (int j = 2; j < i; j++){
                if (i % j == 0){
                    flag = false;
                    break;
                }
            }
            if (flag){
                Console.Write(i + " ");
            }
        }
    }
}

