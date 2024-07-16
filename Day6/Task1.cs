using System;

class Task1
{
    static int[] RemoveElementFromArray(int[] arr, int element)
    {
        int[] result = new int[arr.Length - 1];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != element)
            {
                result[index] = arr[i];
                index++;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array elements separated by space:");
        string[] input = Console.ReadLine().Split(' ');

        int[] nums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        Console.WriteLine("Enter the element to remove:");
        int element = int.Parse(Console.ReadLine());

        int[] result = RemoveElementFromArray(nums, element);

        Console.WriteLine("Array after removing the element:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}