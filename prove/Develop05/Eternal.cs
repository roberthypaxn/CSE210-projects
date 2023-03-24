using System;
using System.IO; 

class Eternal: Goal
{
    private int _completed = 0;
    private int _doneManyTimes = 0;
    public Eternal(string goalType): base(goalType)
    {
        _goalType = goalType;
    }
    public override string CreateGoal(int goalNumber)
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short descriprion of your goal? ");
        _shortDescription = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsAmount = Console.ReadLine();

        string newGoal = $"{goalNumber}~ ~{_goalType}~{_goalName}~{_shortDescription}~{_pointsAmount}~{_completed}~{_doneManyTimes}";
        return newGoal;
    }
}