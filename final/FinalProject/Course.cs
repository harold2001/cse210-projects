using System;

class Course
{
    private readonly string _courseName;
    private readonly List<Person> _students = new();

    public Course(string courseName)
    {
        _courseName = courseName;
    }

    public void AddParticipant(Person person)
    {
        _students.Add(person);
    }

    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"- Name: {_courseName}");
        Console.WriteLine("- Students:");
        if (_students.Count == 0)
        {
            Console.WriteLine("No students");
        }
        else
        {
            int i = 1;
            foreach (Person student in _students)
            {
                Console.WriteLine($"{i}. {student.DisplayInfo()}");
                i++;
            }
        }
    }
}