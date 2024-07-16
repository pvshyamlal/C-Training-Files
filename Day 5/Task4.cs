using System;

class Task3{
    static void Main(string[] args){
        Console.WriteLine("Enter the array elements separated by space:");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++){
            numbers[i] = int.Parse(input[i]);
        }
        int singleNumber = 0;
        for (int i = 0; i < numbers.Length; i++){
            int count = 0;
            for (int j = 0; j < numbers.Length; j++){
                if (numbers[i] == numbers[j]){
                    count++;
                }
            }
            if (count == 1){
                singleNumber = numbers[i];
                break;
            }
        }
        Console.WriteLine("Single number: " + singleNumber);
    }
}