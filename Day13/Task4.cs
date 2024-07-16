using System;
using System.IO;
using System.Threading;

class Task4
{
    static void Main()
    {
        string inputFile = @"S:\CSharp\Day 13\Tasks\input.txt";
        string outputFile = @"S:\CSharp\Day 13\Tasks\output.txt";
        string currentLine = null;
        bool isReadingComplete = false;
        bool isProcessingComplete = false;
        Thread readTh = new Thread(() =>{
            using (StreamReader reader = new StreamReader(inputFile))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = reader.ReadLine();
                    Thread.Sleep(100);
                    while (!isProcessingComplete)
                    {
                        Thread.Sleep(10);
                    }
                }

                isReadingComplete = true;
            }
        });
        Thread processTh = new Thread(() =>{
            while (true)
            {
                while (currentLine == null && !isReadingComplete)
                {
                    Thread.Sleep(10);
                }

                if (currentLine == null && isReadingComplete)
                {
                    break;
                }
                string processedLine = currentLine.ToUpper();
                Thread.Sleep(200);
                while (currentLine != null)
                {
                    Thread.Sleep(10);
                }
                currentLine = processedLine;
                isProcessingComplete = true;
            }
        });
        Thread writerTh = new Thread(() =>{
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                while (true)
                {
                    while (currentLine == null && !isReadingComplete)
                    {
                        Thread.Sleep(10);
                    }
                    if (currentLine == null && isReadingComplete)
                    {
                        break;
                    }
                    writer.WriteLine(currentLine);
                    Thread.Sleep(300);
                    currentLine = null;
                    isProcessingComplete = false;
                }
            }
        });
        readTh.Start();
        processTh.Start();
        writerTh.Start();
        readTh.Join();
        processTh.Join();
        writerTh.Join();
        Console.WriteLine("File processing complete.");
    }
}