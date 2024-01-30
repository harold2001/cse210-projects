using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new("Samuel Bennett", "Multiplication");
        string summary = a1.GetSummary();
        Console.WriteLine(summary);

        MathAssignment a2 = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string summary2 = a2.GetSummary();
        string list = a2.GetHomeworkList();
        Console.WriteLine(summary2);
        Console.WriteLine(list);

        WritingAssignment a3 = new("Mary Waters", "European History", "The Causes of World War II");
        string summary3 = a3.GetSummary();
        string writingInformation = a3.GetWritingInformation();
        Console.WriteLine(summary3);
        Console.WriteLine(writingInformation);
    }
}