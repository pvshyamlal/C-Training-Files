using System;
    class Task4{
        public static void Main(string[] args){
            Console.Write("Enter a double value: ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Original Value before Casting: " + value);
            short val2 = (short)value;
            int val3 = (int)value;
            Console.WriteLine("After Type Casting to short: " + val2);
            Console.WriteLine("After Type Casting to int: " + val3);
        }
}

