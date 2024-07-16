/*
Use Exception Handling in order to get the below output:
Sample Test Case 1:

Command line args 3
The element present at 3 is 40
Sample Test Case 2:

Command line args 6
The mentioned index is out of bounds
*/
using System;
class Task8{
    static void Main(string[] args){
        try{
            int index = int.Parse(args[0]);
            int[] array = { 10, 20, 30, 40, 50 };

            if (index >= 0 && index < array.Length){
                Console.WriteLine("The element present at "+index+" is "+array[index]);
            }
            else{
                throw new IndexOutOfRangeException("The given index is out of bounds");
            }
        }
        catch (IndexOutOfRangeException e){
            Console.WriteLine(e.Message);
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}