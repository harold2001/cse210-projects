using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");

            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        string sign = IsComplete() ? "X" : " ";

        return $"[{sign}] {_shortName} ({_description})";

    }

    public override string GetStringRepresentation()
    {
        string type = GetType().Name;

        return $"{type}:{_shortName},{_description},{_points},{_isComplete}";
    }
}