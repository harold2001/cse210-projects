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
        Console.Clear();

        DisplayPlayerInfo();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        int _answer = int.Parse(Console.ReadLine());

        switch (_answer)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalNames();
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

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

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
        string _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());

        Goal goal = null;
        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(_name, _description, _points);
                break;
                // case 2:
                //     goal = new EternalGoal();
                //     break;
                // case 3:
                //     goal = new ChecklistGoal();
                //     break;
        }

        _goals.Add(goal);
        Start();
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}