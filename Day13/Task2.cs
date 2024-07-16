/*
Race Track Simulation
Create a program that simulates a race between three runners. Each runner is represented by a separate 
thread. The race consists of 5 laps, and after each lap, the runner needs to take a short break. Use 
\the Thread.Sleep() method to simulate the time taken for each lap and break. At the end of the race, 
the main thread should wait for all runner threads to finish before announcing the results.
*/

using System;
using System.Threading;
class Task2{
    static void Run(runner1){
        string name = runner1;
        Console.WriteLine(name+" started running.");
        for (int lap = 1; lap <= 5; lap++){
            Console.WriteLine(name+" completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5){
                Console.WriteLine(name+" taking a short break.");
                Thread.Sleep(3000);
            }
        }
        Console.WriteLine(name+" finished running.");
    }

    static void Run(runner2){
        string name = runner2;
        Console.WriteLine(name+" started running.");
        for (int lap = 1; lap <= 5; lap++){
            Console.WriteLine(name+" completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5){
                Console.WriteLine(name+" taking a short break.");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine(name+" finished running.");
    }

    static void Run(runner3){
        string name = runner3;
        Console.WriteLine(name+" started running.");
        for (int lap = 1; lap <= 5; lap++){
            Console.WriteLine(name+" completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5){
                Console.WriteLine(name+" taking a short break.");
                Thread.Sleep(4000);
            }
        }
        Console.WriteLine(name+" finished running.");
    }
    static void Main(){
        Thread runner1 = new Thread(Runner1);
        Thread runner2 = new Thread(Runner2);
        Thread runner3 = new Thread(Runner3);
        runner1.Start("Runner 1");
        runner2.Start("Runner 2");
        runner3.Start("Runner 3");
        runner1.Join();
        runner2.Join();
        runner3.Join();
        Console.WriteLine("Race finished!");
    }
}