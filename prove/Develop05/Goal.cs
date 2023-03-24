using System;
using System.IO; 

abstract class Goal
{
    protected static List<string> _listOfGoals =  new List<string>();
    protected string _fileName = "goals.txt";
    protected string _goalType;
    protected string _goalName;
    protected string _shortDescription;
    protected string _pointsAmount;
    public Goal(string goalType)
    {
        _goalType = goalType;
    }
    public abstract string CreateGoal(int goalNumber);
}


