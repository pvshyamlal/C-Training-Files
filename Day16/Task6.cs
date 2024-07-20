/*
You are participating in a coding competition where you are given an array of integers and asked to sort it in ascending order.

Complete the below code to achieve the given scenario



Sample Test Case

Enter the number of elements: 5
Enter the elements:
34
22
34
12
67
Sorted Array: [12, 22, 34, 34, 67]
*/
using System;
class Task6{
    static void Main(){
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.Write("Sorted Array: [");
        for (int i = 0; i < n; i++){
            Console.Write(arr[i]);
            if (i < n - 1){
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}