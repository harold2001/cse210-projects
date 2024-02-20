using System;

class Course
{
    private string _courseName;
    private List<Person> _students = new();

    public void AddParticipant(Person person)
    {
        _students.Add(person);
    }

    public void DisplayInfo()
    {

    }
}