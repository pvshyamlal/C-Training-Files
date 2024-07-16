using System;
class Task2{
    static void Main(string[] args){
        int max=0,min=99999;
        Console.WriteLine("Enter the number of people: ");
        int len = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the age of each person:");
        string[] input = Console.ReadLine().Split(' ');
        int[] age = new int[len];
        for (int i = 0; i < len; i++){
            age[i] = int.Parse(input[i]);
        }
        for(int i =0;i<len;i++){        
            if (max < age[i]){          //for max age
                max = age[i];
            }
            if (min > age[i]){          //for min age
                min = age[i];
            }
        }
        Console.WriteLine("Maximum age: "+max);
        Console.WriteLine("Minimum age: "+min);
    }
}