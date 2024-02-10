using System;

class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        int answer = 0;
        while (answer != 6)
        {
            // Console.Clear();

            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        int _count = 1;
        foreach (Goal goal in _goals)
        {
            string name = goal.GetName();
            Console.WriteLine($"{_count}. {name}");
            _count++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int _count = 1;
        foreach (Goal goal in _goals)
        {
            string detail = goal.GetDetailString();

            Console.WriteLine($"{_count}. {detail}");
            _count++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int positionGoal = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[positionGoal - 1];
        int pointsEarned = goalAccomplished.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using StreamWriter outputFile = new(filename);
        outputFile.WriteLine(_score);

        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] firstParts = line.Split(":");
            string type = firstParts[0];

            string[] secondParts = firstParts[1].Split(",");
            string name = secondParts[0];
            string description = secondParts[1];
            int points = int.Parse(secondParts[2]);

            Goal goal = null;
            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(secondParts[3]);
                    goal = new SimpleGoal(name, description, points, isComplete);
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(name, description, points);
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(secondParts[3]);
                    int target = int.Parse(secondParts[4]);
                    int amountCompleted = int.Parse(secondParts[5]);
                    goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                    break;
            }

            _goals.Add(goal);
        }
    }
}