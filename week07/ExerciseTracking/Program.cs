using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(new DateTime(2025, 6, 18), 30, 3.0);       // 3 miles in 30 mins
        Cycling cycle = new Cycling(new DateTime(2025, 6, 15), 45, 20.0);    // 20 mph for 45 mins
        Swimming swim = new Swimming(new DateTime(2025, 6, 19), 30, 30);

        // Display summaries
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(cycle.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}