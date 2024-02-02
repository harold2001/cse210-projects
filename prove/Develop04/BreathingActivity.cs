using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
    }

    public void Breathing()
    {
        Console.WriteLine("Breath in...");
        Thread.Sleep(3000);
        Console.WriteLine("Breath out...");
        Thread.Sleep(3000);
    }

    public void BreathingActivityStart()
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
        Console.WriteLine("Start breathing...");
        Thread.Sleep(3000);
        for (int i = 0; i < _duration; i++)
        {
            Breathing();
            Console.WriteLine($"You have completed {i + 1} seconds of the breathing activity.");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Breathing activity is complete.");
    }

    public void BreathingActivityEnd()
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
        Console.WriteLine("Start breathing...");
        Thread.Sleep(3000);

    }
}