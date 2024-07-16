using System;
class Task7{
    static void Main(){
        Console.WriteLine("Enter the array elements separated with spaces");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[input.Length];
        Console.WriteLine("Duplicate values in the array:");
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}