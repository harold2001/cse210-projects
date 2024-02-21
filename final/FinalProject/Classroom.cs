using System;

class Classroom
{
    private readonly string _roomNumber;
    private readonly List<Student> _students = new();

    public Classroom(string roomNumber)
    {
        _roomNumber = roomNumber;
    }

    public string GetNumber()
    {
        return _roomNumber;
    }

    public void AddStudent()
    {
        Console.WriteLine();
        Console.Write("What is the name the student? ");
        string name = Console.ReadLine();

        Console.Write("What is the student's grade? (1-10) ");
        int grade = int.Parse(Console.ReadLine());

        Console.Write("How old is she/he? ");
        int age = int.Parse(Console.ReadLine());

        Student student = new(name, age, grade);
        _students.Add(student);
        Console.WriteLine("Student added!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"- Classroom {_roomNumber}");
        Console.WriteLine($"- Students {_students.Count}: ");
        int i = 1;
        foreach (Student student in _students)
        {
            Console.WriteLine($"{i}. {student.DisplayInfo()}");
            i++;
        }
    }
}