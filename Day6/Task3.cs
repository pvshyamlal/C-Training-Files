using System;

class Task3
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Leaders in the array:");
        PrintLeaders(arr);
    }

    static void PrintLeaders(int[] arr)
    {
        int maxRight = arr[arr.Length - 1];
        Console.WriteLine(maxRight + " ");

        for (int i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] >= maxRight)
            {
                Console.WriteLine(arr[i] + " ");
                maxRight = arr[i];
            }
        }
    }
}