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
/*class Goal
{
    private string _goalName;
    private string _shortDescription;
    protected string _pointsAmount;
    protected int _pointsAchieved = 0;
    protected List<string> _listOfGoals =  new List<string>();
    private bool _isComplete = false;
    private string fileName = "goals.txt";
    private string _typeOfGoal = "";
    private int goalNumber = 1;
    public Goal()
    {          
    }
    public List<string> CreateGoal(int typeOfGoal)
    {
        switch(typeOfGoal)
            {
                case 1:
                    _typeOfGoal = "Simple Goal";
                    break;
                case 2:
                    _typeOfGoal = "Eternal Goal";
                    break;
                case 3:
                    _typeOfGoal = "Checklist Goal";
                    break;
                default:
                    break;
            }
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short descriprion of your goal? ");
        _shortDescription = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsAmount = Console.ReadLine();
        
        string newGoal = $"{goalNumber}. {_typeOfGoal}: {_goalName}~{_shortDescription}~{_pointsAmount}";
        _listOfGoals.Add(newGoal);
        goalNumber ++;
        return _listOfGoals;
    }
    
    public void ListGoals()
    {
        foreach (string goal in _listOfGoals)
        {
            Console.WriteLine(goal);
        }

        // Update the original goalList variable with the updated _listOfGoals
    }
    
    public void SaveGoals(List<string> goalsInList)
    {
        using (StreamWriter goalsFile = new StreamWriter(fileName, true))
        {
            foreach (string goal in goalsInList)
            {
                goalsFile.WriteLine(goal);
            }
        }
    }
    public void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] parts = line.Split("~");

            string oneGoal = parts[0];
            string descriprionOfGoal = parts[1];
            string pointsForGoal = parts[2];
        }
    }
    public List<string> GetGoals(List<string> listOfGoals){
        listOfGoals = _listOfGoals;
        return listOfGoals;
    }
    public virtual List<string> IsComplete(List<string> goalsInList)
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        foreach (string goal in goalsInList)
        {
            Console.WriteLine(goal);
        }
        Console.WriteLine("Which goal did you accomplish? ");
        string completeGoal = Console.ReadLine();
        int completedGoal = int.Parse(completeGoal);
        string oneDown = _listOfGoals[completedGoal-1];
        _isComplete = true;
        string doneOrNot = (_isComplete) ? "X": " ";
        string aSingleGoal = $"[{doneOrNot}] {oneDown}";
        _pointsAchieved = _pointsAchieved + int.Parse(_pointsAmount);
        Console.WriteLine(aSingleGoal);
        //_listOfGoals.Add(aSingleGoal);
        return _listOfGoals;
    }
    public int GetPoints()
    {
        return _pointsAchieved;
    }
}*/


