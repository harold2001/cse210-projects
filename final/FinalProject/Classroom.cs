using System;

class Classroom
{
    private string _roomNumber;
    private List<Student> _students = new();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void DisplayInfo()
    {

    }
}