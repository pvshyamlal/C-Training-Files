using System;
namespace App
{
    public class Arithmetic
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Sum of "+a+" and "+b+" is "+(a+b));
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Difference of "+a+" and "+b+" is "+(a-b));
        }
		public static void Mul(int a, int b)
        {
            Console.WriteLine("Product of "+a+" and "+b+" is "+(a*b));
        }
    }

    public class Task2
    {
        public static void Main(string[] args)
        {
            int a = 34;
            int _b = 33;
            int @c = 10;

            Arithmetic.Add(a, _b);
            Arithmetic.Sub(_b, a);
			Arithmetic.Mul(@c,_b);
        }
    }
}
