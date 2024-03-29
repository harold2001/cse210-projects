using System;

class Student : Person
{
    private int _gradeLevel;

    public Student(string name, int age, int gradeLevel) : base(name, age)
    {
        _gradeLevel = gradeLevel;
    }

    public override string DisplayInfo()
    {
        return $"Name: {_name}, Age: {_age}, Grade Level: {_gradeLevel}";
    }
}