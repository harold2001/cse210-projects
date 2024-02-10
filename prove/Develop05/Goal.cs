using System;

abstract class Goal
{
    protected readonly string _shortName;
    protected readonly string _description;
    protected readonly int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }
}