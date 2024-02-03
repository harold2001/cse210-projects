using System;

class ReflectingActivity : Activity
{
    private readonly List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random = new();
        int randomIndex = random.Next(_questions.Count);

        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string response = Console.ReadLine();

        if (response == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.Clear();
        }
    }

    public void DisplayQuestions()
    {
        string lastQuestion = "";
        for (int i = 0; i < 2; i++)
        {
            string randomQuestion = GetRandomQuestion();

            while (randomQuestion == lastQuestion)
            {
                randomQuestion = GetRandomQuestion();
            }
            lastQuestion = randomQuestion;

            Console.Write($"> {randomQuestion} ");
            ShowSpinner(8);
            Console.WriteLine();
        }
    }
}