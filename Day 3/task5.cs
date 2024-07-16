using System;
    class Task5{
        public static void Main(string[] args){
            Console.Write("Enter a short value: ");
            short value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Original short value: " + value);
            char charValue = (char)value;
            Console.WriteLine("Converted char value: " + charValue);
        }
}

