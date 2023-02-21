using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Robert Hypax NDIRAMIYE", "Carl Panzram Papers");
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine("------------------------------------------------------------------------------");
        MathAssignment mathAss = new MathAssignment("Robert Hypax NDIRAMIYE", "Harmonices Mundi", "8.1", "4-12");
        Console.WriteLine(mathAss.GetSummary());
        Console.WriteLine(mathAss.GetHomeworkList());
        Console.WriteLine("------------------------------------------------------------------------------");
        WritingAssignment writingAss = new WritingAssignment("Robert Hypax", "Undying Wars of D.R.C", "The Involvement Of U.S.A, China, and Russia");
        Console.WriteLine(writingAss.GetSummary());
        Console.WriteLine(writingAss.GetWritingInformation());
    }
}