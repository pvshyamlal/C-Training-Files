using System;
using System.Threading;

class TaskManager
{
    static void Main()
    {
        Thread[] workTh = new Thread[5];
        for (int i = 0; i < workTh.Length; i++)
        {
            workTh[i] = new Thread(WorkerThread);
            workTh[i].Name = ("Worker "+i + 1);
            workTh[i].Start();
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Worker thread status:");
            foreach (Thread workerThread in workTh)
            {
                Console.WriteLine(workerThread.Name+": "+workerThread.ThreadState);
            }
            Console.WriteLine();

            Thread.Sleep(1000);
        }
        Console.WriteLine("Stopping all worker threads...");
        foreach (Thread workerThread in workTh)
        {
            workerThread.Abort();
        }

        Console.WriteLine("Final status report:");
        foreach (Thread workerThread in workTh)
        {
            Console.WriteLine(workerThread.Name+": "+workerThread.ThreadState);
        }
    }
    static void WorkerThread()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Thread.CurrentThread.Name+" is performing task "+i + 1);
            Thread.Sleep(1000);
        }
    }
}