using System;
    public class Task6{
        public static void Main(string[] args){
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate of interest (in percentage): ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());
            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest: "+simpleInterest);
        }
}

