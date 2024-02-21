using System;

class Department
{
    private readonly string _name;
    private readonly List<Course> _courses = new();

    public Department(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void AddCourse()
    {
        Console.WriteLine();
        Console.Write("What is the name of the course? ");
        string name = Console.ReadLine();

        Course course = new(name);
        _courses.Add(course);
        Console.WriteLine("Course added!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Department: {_name}");
        Console.WriteLine("Courses:");
        foreach (Course course in _courses)
        {
            course.DisplayInfo();
        }
        Console.WriteLine();
    }
}