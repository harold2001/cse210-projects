using System;

class Department
{
    private string _name;
    private List<Course> _courses = new();

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public void ShowCourses()
    {

    }
}