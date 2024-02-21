using System;
using System.Collections.Generic;
using System.Linq;

class School
{
    private readonly string _name;
    private readonly List<Department> _departments = new();
    private readonly List<Classroom> _classrooms = new();
    private readonly List<Activity> _activities = new();

    public School(string name)
    {
        _name = name;
    }

    public void Welcome()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {_name}!");
            ShowMainMenu();
            Console.Write("Please select an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                    ProcessAction(choice);
                    break;
                case 4:
                    DisplayInfo();
                    break;
                case 5:
                    Console.WriteLine("Thank you :)");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        } while (choice != 5);
    }

    private void ShowMainMenu()
    {
        Console.WriteLine("1. Department");
        Console.WriteLine("2. Classroom");
        Console.WriteLine("3. Activity");
        Console.WriteLine("4. Display school info");
        Console.WriteLine("5. Exit");
    }

    private void ProcessAction(int mainChoice)
    {
        Console.WriteLine();
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Get amount");
        Console.WriteLine("3. List");
        Console.Write("Select the action: ");
        int secondChoice = int.Parse(Console.ReadLine());

        Console.WriteLine();
        if (secondChoice == 1)
        {
            switch (mainChoice)
            {
                case 1:
                    AddDepartment();
                    break;
                case 2:
                    AddClassroom();
                    break;
                case 3:
                    AddActivity();
                    break;
            }
            Console.WriteLine("Successfully created!");
        }
        else if (secondChoice == 2)
        {
            switch (mainChoice)
            {
                case 1:
                    Console.WriteLine($"The amount of departments is: {_departments.Count}");
                    break;
                case 2:
                    Console.WriteLine($"The amount of classrooms is: {_classrooms.Count}");
                    break;
                case 3:
                    Console.WriteLine($"The amount of activities is: {_activities.Count}");
                    break;
            }
        }
        else if (secondChoice == 3)
        {
            DisplayList(mainChoice);
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void AddDepartment()
    {
        Console.Write("Please enter the name of the department: ");
        string depName = Console.ReadLine();
        Department department = new(depName);
        _departments.Add(department);
    }

    private void AddClassroom()
    {
        Console.Write("Please enter the number of the classroom: ");
        string classNumber = Console.ReadLine();
        Classroom classroom = new(classNumber);
        _classrooms.Add(classroom);
    }

    private void AddActivity()
    {
        Console.Write("Please enter the name of the activity: ");
        string activityName = Console.ReadLine();
        Activity activity = new(activityName);
        _activities.Add(activity);
    }

    private void DisplayList(int mainChoice)
    {
        int count = 0;
        int i = 1;
        switch (mainChoice)
        {
            case 1:
                Console.WriteLine("The list of departments:");
                foreach (Department department in _departments)
                {
                    Console.WriteLine($"{i}. {department.GetName()}");
                    i++;
                }
                count = _departments.Count;
                break;
            case 2:
                Console.WriteLine("The list of classrooms:");
                foreach (Classroom classroom in _classrooms)
                {
                    Console.WriteLine($"{i}. {classroom.GetNumber()}");
                    i++;
                }
                count = _classrooms.Count;
                break;
            case 3:
                Console.WriteLine("The list of activities:");
                foreach (Activity activity in _activities)
                {
                    Console.WriteLine($"{i}. {activity.GetName()}");
                    i++;
                }
                count = _activities.Count;
                break;
        }

        if (count > 0)
        {
            Console.WriteLine();
            Console.Write("Select one of the above: ");
            int number = int.Parse(Console.ReadLine());

            int choice;
            switch (mainChoice)
            {
                case 1:
                    Department department = _departments[number - 1];

                    Console.WriteLine();
                    Console.WriteLine("1. Add a course.");
                    Console.WriteLine("2. Display information.");
                    Console.Write("Select the action: ");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        department.AddCourse();
                    }
                    else if (choice == 2)
                    {
                        department.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }

                    break;
                case 2:
                    Classroom classroom = _classrooms[number - 1];
                    Console.WriteLine();
                    Console.WriteLine("1. Add a student.");
                    Console.WriteLine("2. Display information.");
                    Console.Write("Select the action: ");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        classroom.AddStudent();
                    }
                    else if (choice == 2)
                    {
                        classroom.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }
                    break;
                case 3:
                    Activity activity = _activities[number - 1];

                    Console.WriteLine();
                    Console.WriteLine("1. Add a participant.");
                    Console.WriteLine("2. Display information.");
                    Console.Write("Select the action: ");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        activity.AddParticipant();
                    }
                    else if (choice == 2)
                    {
                        activity.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("There are no items to display.");
        }
    }

    private void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"School name: {_name}");

        string departments = string.Join(", ", _departments.Select(d => d.GetName()));
        string classrooms = string.Join(", ", _classrooms.Select(c => c.GetNumber()));
        string activities = string.Join(", ", _activities.Select(a => a.GetName()));

        Console.WriteLine($"Departments: {departments}");
        Console.WriteLine($"Classrooms: {classrooms}");
        Console.WriteLine($"Activities: {activities}");

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
