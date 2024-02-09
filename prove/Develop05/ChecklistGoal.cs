using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}