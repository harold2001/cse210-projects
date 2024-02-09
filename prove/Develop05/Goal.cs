using System;

abstract class Goal
{
    private readonly string _shortName;
    private readonly string _description;
    private readonly int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();
}