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
    static void Run1(){
        Console.WriteLine("Runner1 started running.");
        for (int lap = 1; lap <= 5; lap++){
            Console.WriteLine("Runner1 completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5){
                Console.WriteLine("Runner1 taking a short break.");
                Thread.Sleep(3000);
            }
        }
        Console.WriteLine("Runner1 finished running.");
    }

    static void Run2(){
        Console.WriteLine("Runner2 started running.");
        for (int lap = 1; lap <= 5; lap++){
            Console.WriteLine("Runner2 completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5){
                Console.WriteLine("Runner2 taking a short break.");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("Runner2 finished running.");
    }

    static void Run3(){
        Console.WriteLine("Runner3 started running.");
        for (int lap = 1; lap <= 5; lap++){
            Console.WriteLine("Runner3 completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5){
                Console.WriteLine("Runner3 taking a short break.");
                Thread.Sleep(4000);
            }
        }
        Console.WriteLine("Runner3 finished running.");
    }
    static void Main(){
        Thread runner1 = new Thread(new ThreadStart(Run1));
        Thread runner2 = new Thread(new ThreadStart(Run2));
        Thread runner3 = new Thread(new ThreadStart(Run3));
        runner1.Start();
        runner2.Start();
        runner3.Start();
        runner1.Join();
        runner2.Join();
        runner3.Join();
        Console.WriteLine("Race finished!");
    }
}