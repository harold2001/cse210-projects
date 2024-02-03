using System;

class ListingActivity : Activity
{
    private int _count = 0;
    private readonly List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();

        Console.WriteLine();

        List<string> list = GetListFromUser();
        _count = list.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new();

        DateTime currentTime = DateTime.Now;
        while (endTime > currentTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            responses.Add(userInput);
            currentTime = DateTime.Now;
        }

        Console.WriteLine("This is what you have listed. Is it ok? (Y/N): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "n" || answer.ToLower() == "no")
        {
            Console.WriteLine("Please enter the items again:");
            List<string> list = GetListFromUser();
            return list;
        }
        else if (answer.ToLower() == "y" || answer.ToLower() == "yes")
        {
            Console.WriteLine("List saved.");
            return responses;
        }
        else
        {
            Console.WriteLine("Invalid input. Assumming 'Y' and saving list...");
            return responses;
        }
    }
}