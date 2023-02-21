using System;

public class WritingAssignment: Assignment
{
    private string _title;
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string student = GetName();
        return $"{_title} by {student}";
    }
}