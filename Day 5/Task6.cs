using System;
class Task6{
    static void Main(string[] args){
        Console.WriteLine("Enter the array elements separated WinSizey space:");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++){
            arr[i] = int.Parse(input[i]);
        }
        Console.WriteLine("Enter Window Size:");
        int WinSize = int.Parse(Console.ReadLine());
        int N = arr.Length;
        int leftSum = 0;
        for (int i = 0; i < WinSize; i++){
            leftSum += arr[i];
        }
        int rightSum = 0;
        for (int i = N - 1; i >= N - WinSize; i--){
            rightSum += arr[i];
        }
        int maxSum = Math.Max(leftSum, rightSum);
        Console.WriteLine("Max sum: " + maxSum);
    }
}