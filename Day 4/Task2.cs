using System;
class Task1{
    static void Main(){
        Console.Write("Did you clear the written test? (yes/no): ");
        string test = Console.ReadLine();
        if (test == "yes"){
            Console.WriteLine("You are eligible for the group discussion round");
            Console.Write("Did you pass the group discussion round? (yes/no): ");
            string disc = Console.ReadLine();
            if(disc=="yes"){
                Console.WriteLine("You are eligible for the technical round");
                Console.Write("Did you pass the technical round? (yes/no): ");
                string tech = Console.ReadLine();
                if(tech == "yes"){
                    Console.WriteLine("Congrats! You are eligible for the HR round");
                }
                else{
                    Console.WriteLine("Sorry,You can go home");
                }
            }
            else{
                Console.WriteLine("Sorry,You can go home");
            }
        }
        else{
            Console.WriteLine("Sorry,You can go home");
        }
    }
}