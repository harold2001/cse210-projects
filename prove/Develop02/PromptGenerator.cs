using System;
using System.Collections.Generic;

class PromptGenerator
{
    private readonly List<string> _prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            throw new InvalidOperationException("No hay preguntas disponibles.");
        }

        Random random = new();
        int randomIndex = random.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}
