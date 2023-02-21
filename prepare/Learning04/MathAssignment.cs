using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string name, string topic, string bookSection, string problems) : base(name, topic)
    {
        _textBookSection = bookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}