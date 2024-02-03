using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Breathing(2, 4);
        DateTime currentTime = DateTime.Now;

        while (futureTime > currentTime)
        {
            Breathing(4, 6);

            currentTime = DateTime.Now;
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of Breathing Activity.");
    }

    public static void Breathing(int inDuration, int outDuration)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write($"Breath in...{inDuration}");

        while (inDuration > 0)
        {
            --inDuration;

            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(inDuration);

        }
        Console.Write("\b \b");

        Console.WriteLine("");

        Console.Write($"Now breath out...{outDuration}");

        while (outDuration > 0)
        {
            --outDuration;

            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(outDuration);

        }

        Console.Write("\b \b");
    }
}