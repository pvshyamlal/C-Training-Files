using System;

namespace FibonacciSequence
{
    public class Program
    {
        // Recursive method to calculate Fibonacci numbers
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Non-recursive method to calculate Fibonacci numbers
        public static void FibonacciNonRecursive(int n)
        {
            int a = 0, b = 1, next;

            if (n >= 1)
                Console.Write(a + " ");
            if (n >= 2)
                Console.Write(b + " ");

            for (int i = 2; i < n; i++)
            {
                next = a + b;
                Console.Write(next + " ");
                a = b;
                b = next;
            }
        }

        public static void Main(string[] args)
        {
            // Prompt the user to enter the range
            Console.Write("Enter the range: ");
            int range = Convert.ToInt32(Console.ReadLine());

            // Display the Fibonacci sequence using recursion
            Console.WriteLine("Fibonacci Sequence (Recursive):");
            for (int i = 0; i < range; i++)
            {
                Console.Write(FibonacciRecursive(i) + " ");
            }
            Console.WriteLine();

            // Display the Fibonacci sequence using a non-recursive method
            Console.WriteLine("Fibonacci Sequence (Non-Recursive):");
            FibonacciNonRecursive(range);
            Console.WriteLine();
        }
    }
}
