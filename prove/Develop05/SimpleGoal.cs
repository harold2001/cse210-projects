using System;

class SimpleGoal : Goal
{
    private readonly bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}