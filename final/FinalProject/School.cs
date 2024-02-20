using System;

class School
{
    private string _name;
    private List<Department> _departments = new();
    private List<Classroom> _classrooms = new();
    private List<Activity> _activities = new();

    public School(string name)
    {
        _name = name;
    }

    public void Welcome()
    {
        Console.WriteLine($"Welcome to {_name}!");
    }

    public void AddDepartment(Department department)
    {
        _departments.Add(department);
    }

    public void AddClassroom(Classroom classroom)
    {
        _classrooms.Add(classroom);
    }

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public void DisplayInfo()
    {

    }
}