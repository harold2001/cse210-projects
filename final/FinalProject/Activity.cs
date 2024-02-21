using System;

class Activity
{
    private readonly string _name;
    private readonly List<Person> _participants = new();

    public Activity(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void AddParticipant()
    {
        Console.WriteLine();

        Console.Write("Is the participant an student(S) or teacher(T)? (S/T) ");
        string answer = Console.ReadLine().ToLower();

        Console.Write("What is the participant's name? ");
        string name = Console.ReadLine();

        Console.Write("What is the participant's age? ");
        int age = int.Parse(Console.ReadLine());

        if (answer == "s")
        {
            Console.Write("What is the student's grade? (1-10) ");
            int grade = int.Parse(Console.ReadLine());

            Student student = new(name, age, grade);
            _participants.Add(student);
            Console.WriteLine("Participant added!");
        }
        else if (answer == "t")
        {
            Console.Write("What is the teacher's subject? ");
            string subject = Console.ReadLine();

            Teacher teacher = new(name, age, subject);
            _participants.Add(teacher);
            Console.WriteLine("Participant added!");
        }
        else
        {
            Console.WriteLine("Invalid answer");

        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Activity: {_name}");
        int i = 1;
        foreach (Person participant in _participants)
        {
            Console.WriteLine($"{i}. {participant.GetType()}: {participant.DisplayInfo()}");
            i++;
        }
    }
}