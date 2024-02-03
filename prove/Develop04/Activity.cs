using System;

class Activity
{
    private readonly string _name;
    private readonly string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity.");
        ShowSpinner(4);
    }

    public static void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        while (futureTime > currentTime)
        {
            Console.Write("-");

            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("|");

            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");

            Thread.Sleep(250);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }

    public static void ShowCountdown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            --seconds;
        }
    }
}