using System;
using System.IO; 

class Checklist: Goal
{
    public Checklist(string goalType): base(goalType)
    {
        _goalType = goalType;

    }
    private string _levels;
    private string _bonus;
    private int _completed = 0;
    private int _doneManyTimes = 0;
    public override string CreateGoal(int goalNumber)
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short descriprion of your goal? ");
        _shortDescription = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsAmount = Console.ReadLine();

        Console.Write("How many times this goal needs to be accomplished for a bonus? ");
        _levels = Console.ReadLine();

        Console.Write("What is the bonus for accomplishing the goal that many times? ");
        _bonus = Console.ReadLine();
        
        string newGoal = $"{goalNumber}~ ~{_goalType}~{_goalName}~{_shortDescription}~{_pointsAmount}~{_completed}~{_levels}~{_bonus}~{_doneManyTimes}";
        return newGoal;
    }
}