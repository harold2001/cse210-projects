using System;

class Teacher : Person
{
    private string _subject;

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        _subject = subject;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}, Subject: {_subject}");
    }
}