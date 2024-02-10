using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private readonly int _target;
    private readonly int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }

        _amountCompleted++;

        int total = _points;
        if (IsComplete())
        {
            total += _bonus;
        }

        Console.WriteLine($"Congratulations! You have earned {total} points!");

        return total;
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailString()
    {
        string sign = IsComplete() ? "X" : " ";
        return $"[{sign}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        string type = GetType().Name;

        return $"{type}:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}