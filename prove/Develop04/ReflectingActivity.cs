using System;

class ReflectingActivity : Activity
{
    private readonly List<string> _prompts = new();
    private readonly List<string> _questions = new();

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}