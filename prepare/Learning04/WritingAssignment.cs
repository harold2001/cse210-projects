using System;

class WritingAssignment : Assignment
{
    private readonly string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = base.GetStudentName();
        return $"Section {_title} Problems {studentName}";
    }
}