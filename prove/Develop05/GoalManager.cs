using System;
using System.IO;

class GoalManager
{
    private int _goalNumber;
    private List<string> _currentGoals;
    private int _pointsAchieved;
    public GoalManager(int goalNumber, List<string> currentGoal, int pointsAchieved)
    {
        _goalNumber = goalNumber;
        _currentGoals = currentGoal;
        _pointsAchieved = pointsAchieved;
    }
    public List<string> GetSavedGoals()
    {
        List<string> savedGoals = new List<string>();
        //Read the file
        string[] lines = System.IO.File.ReadAllLines("goals.txt");
        int numberOfGoals = lines.Count();
        //Populate the list of goals with the lines from the file.
        foreach (string line in lines)
        {
            savedGoals.Add(line);
        }
        if(!(lines.Count() == 0)){
            _goalNumber = numberOfGoals + 1;
        }
        return savedGoals;
    }
    public void LoadGoals()
    {
        foreach (string line in GetSavedGoals())
        {
            string[] parts = line.Split("~");
            if (parts[2] == "Simple Goal")
            {
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]}: {parts[3]} ({parts[4]})");
            } else if (parts[2] == "Eternal Goal") {
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]}: {parts[3]} ({parts[4]})");
            } else if (parts[2] == "Checklist Goal"){
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]}: {parts[3]} ({parts[4]}) -- Currently completed: {parts[6]}/{parts[7]}");
            }
        }
    }
    public void ListGoals()
    {
        foreach (string oneGoal in _currentGoals)
        {
            string[] parts = oneGoal.Split("~");
            if (parts[2] == "Simple Goal")
            {
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]}: {parts[3]} ({parts[4]})");
            } else if (parts[2] == "Eternal Goal") {
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]}: {parts[3]} ({parts[4]})");
            } else if (parts[2] == "Checklist Goal"){
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]}: {parts[3]} ({parts[4]}) -- Currently completed: {parts[6]}/{parts[7]}");
            }
        }
    }
    public List<string> GetAllGoals()
    {
        List<string> allGoals = new List<string>();
        foreach (string line in GetSavedGoals())
        {
            allGoals.Add(line);
            
        }
        
        foreach (string line in _currentGoals)
        {
            if (!(allGoals.Contains(line)))
            {
                string savedFormat;
                string[] parts = line.Split("~");
                if (parts[2] == "Simple Goal")
                {
                    savedFormat = $"{parts[0]}~{parts[1]}~{parts[2]}~{parts[3]}~{parts[4]}~{parts[5]}" ;
                } else if(parts[2] == "Eternal Goal")
                {
                    savedFormat = $"{parts[0]}~{parts[1]}~{parts[2]}~{parts[3]}~{parts[4]}~{parts[5]}~{parts[6]}~{parts[7]}";
                }
                else{
                    savedFormat = $"{parts[0]}~{parts[1]}~{parts[2]}~{parts[3]}~{parts[4]}~{parts[5]}~{parts[6]}~{parts[7]}~{parts[8]}~{parts[9]}" ;
                }
                allGoals.Add(savedFormat);
            }
        }
        
        return allGoals;
    }
    public void SaveGoals()
    {
        // read the file, see what's in it. If any lines in all list is in the file, don't rewrite it.
        List<string> allGoals = GetAllGoals();
        
        using (StreamWriter goalsFile = new StreamWriter("goals.txt",false))
        {
            foreach (string goal in allGoals)
            {
                goalsFile.WriteLine(goal);
            }
        }
    }
    public void IsComplete()
    {
        List<string> all = GetAllGoals();
        //display the goals to choose from
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        foreach (string oneGoal in all)
        {
            string[] parts = oneGoal.Split("~");
            if (parts[2] == "Simple Goal")
            {
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]} ({parts[3]})");
            } else if (parts[2] == "Eternal Goal") {
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]} ({parts[3]})");
            } else if (parts[2] == "Checklist Goal"){
                Console.WriteLine($"{parts[0]}. [{parts[1]}] {parts[2]} ({parts[3]}) -- Currently completed: {parts[6]}/{parts[7]}");
            }
        }
        Console.Write("Which goal did you accomplish? ");
        string completeGoal = Console.ReadLine();
        int completedGoal = int.Parse(completeGoal);
        string oneDown = all[completedGoal-1];
        string[] partsOfAchievedGoal = oneDown.Split("~");
        List<string> savedOnes = GetSavedGoals();
        if(_currentGoals.Contains(oneDown) && !(savedOnes.Contains(oneDown)))
        {
            int indexOfGoal = _currentGoals.IndexOf(oneDown);
            if (partsOfAchievedGoal[2] == "Simple Goal")
            {
                partsOfAchievedGoal[1] = "X";
            }else if(partsOfAchievedGoal[2] == "Eternal Goal"){
                int point = int.Parse(partsOfAchievedGoal[6]) + 1;
                partsOfAchievedGoal[6] = point.ToString();
            }else if (partsOfAchievedGoal[2] == "Checklist Goal"){
                if(int.Parse(partsOfAchievedGoal[6]) < int.Parse(partsOfAchievedGoal[7]))
                {
                    int completing = int.Parse(partsOfAchievedGoal[6]) + 1;
                    partsOfAchievedGoal[6] = completing.ToString();
                }
                if(int.Parse(partsOfAchievedGoal[6]) == int.Parse(partsOfAchievedGoal[7]))
                {
                    partsOfAchievedGoal[1] = "X";
                }
            }
            oneDown = string.Join("~", partsOfAchievedGoal);
            if(_currentGoals.Count() == 1)
            {
                _currentGoals[0] = oneDown;
            }else{
                _currentGoals[indexOfGoal] = oneDown;
            }
            Console.WriteLine();
            Console.WriteLine($"Congratulations!!! You have earned {partsOfAchievedGoal[5]} points");
            
            if(partsOfAchievedGoal[2] == "Checklist Goal" && int.Parse(partsOfAchievedGoal[6]) == int.Parse(partsOfAchievedGoal[7]))
                Console.WriteLine($"You've now unlocked a bonus of {partsOfAchievedGoal[8]} points");

            Console.WriteLine("Please save your goals to recover your progress next time you use the program"); 
        }else if(_currentGoals.Contains(oneDown) && savedOnes.Contains(oneDown)){
            int indexOfGoalInCurrent = _currentGoals.IndexOf(oneDown);
            int indexOfGoalInSaved = savedOnes.IndexOf(oneDown);
            if (partsOfAchievedGoal[2] == "Simple Goal" && !(partsOfAchievedGoal[1] == "X"))
            {
                partsOfAchievedGoal[1] = "X";
            }else if(partsOfAchievedGoal[2] == "Eternal Goal"){
                int point = int.Parse(partsOfAchievedGoal[6]) + 1;
                partsOfAchievedGoal[6] = point.ToString();
            }else if (partsOfAchievedGoal[2] == "Checklist Goal"){
                if(int.Parse(partsOfAchievedGoal[6]) < int.Parse(partsOfAchievedGoal[7]))
                {
                    int completing = int.Parse(partsOfAchievedGoal[6]) + 1;
                    partsOfAchievedGoal[6] = completing.ToString();
                }
                if(int.Parse(partsOfAchievedGoal[6]) == int.Parse(partsOfAchievedGoal[7]))
                {
                    partsOfAchievedGoal[1] = "X";
                }
            }
            oneDown = string.Join("~", partsOfAchievedGoal);
            if(_currentGoals.Count() == 1)
            {
                _currentGoals[0] = oneDown;
            }else if(!(savedOnes.Count() == 0) && !(_currentGoals.Count() == 0)){
                _currentGoals[indexOfGoalInCurrent] = oneDown;
            }else{
                _currentGoals[indexOfGoalInCurrent] = oneDown;
            }
            if(savedOnes.Count() == 1){
                savedOnes[0] = oneDown;
            }else{
                savedOnes[indexOfGoalInSaved] = oneDown;
            }
            using (StreamWriter goalsFile = new StreamWriter("goals.txt",false))//problem
            {
                foreach (string goal in savedOnes)
                {
                    goalsFile.WriteLine(goal);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Congratulations!!! You have earned {partsOfAchievedGoal[5]} points");
            
            if(partsOfAchievedGoal[2] == "Checklist Goal" && int.Parse(partsOfAchievedGoal[6]) == int.Parse(partsOfAchievedGoal[7]))
                Console.WriteLine($"You've now unlocked a bonus of {partsOfAchievedGoal[8]} points");

        }else if(savedOnes.Contains(oneDown) && !(_currentGoals.Contains(oneDown)))
        {
            int indexOfGoal = savedOnes.IndexOf(oneDown);
            
            if (partsOfAchievedGoal[2] == "Simple Goal" && !(partsOfAchievedGoal[1] == "X"))
            {
                partsOfAchievedGoal[1] = "X";
            }else if(partsOfAchievedGoal[2] == "Eternal Goal"){
                int point = int.Parse(partsOfAchievedGoal[6]) + 1;
                partsOfAchievedGoal[6] = point.ToString();
            }else if (partsOfAchievedGoal[2] == "Checklist Goal"){
                if(int.Parse(partsOfAchievedGoal[6]) < int.Parse(partsOfAchievedGoal[7]))
                {
                    int completing = int.Parse(partsOfAchievedGoal[6]) + 1;
                    partsOfAchievedGoal[6] = completing.ToString();
                }
                if(int.Parse(partsOfAchievedGoal[6]) == int.Parse(partsOfAchievedGoal[7]))
                {
                    partsOfAchievedGoal[1] = "X";
                }
            }
            oneDown = string.Join("~", partsOfAchievedGoal);
            if(savedOnes.Count() == 1){
                savedOnes[0] = oneDown;
            }else{
                savedOnes[indexOfGoal] = oneDown;
            }
            oneDown = string.Join("~", partsOfAchievedGoal);
            using (StreamWriter goalsFile = new StreamWriter("goals.txt",false))
            {
                foreach (string goal in savedOnes)
                {
                    goalsFile.WriteLine(goal);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Congratulations!!! You have earned {partsOfAchievedGoal[5]} points");
            
            if(partsOfAchievedGoal[2] == "Checklist Goal" && int.Parse(partsOfAchievedGoal[6]) == int.Parse(partsOfAchievedGoal[7]))
                Console.WriteLine($"You've now unlocked a bonus of {partsOfAchievedGoal[8]} points");
        }
    }
    public int Achievement()
    {
        List<string> goals = GetAllGoals();
        _pointsAchieved = 0;
        foreach(string goal in goals)
        {
            string[] parts =goal.Split("~");
            if(parts[2] == "Simple Goal" && parts[1] == "X" && !(parts[5] == "done"))
            {
                _pointsAchieved = _pointsAchieved + int.Parse(parts[5]);
                parts[5] = "done";
            }else if(parts[2] == "Eternal Goal" && !(parts[6] == "0") && parts[7]=="0"){
                _pointsAchieved = _pointsAchieved + (int.Parse(parts[5]) * int.Parse(parts[6]));
                int manyTimes = int.Parse(parts[6]);
                parts[7] = manyTimes.ToString();
            }else if(parts[2] == "Eternal Goal" && !(parts[6] == "0") && !(int.Parse(parts[7])== int.Parse(parts[6]))){
                _pointsAchieved = _pointsAchieved + (int.Parse(parts[5]) * int.Parse(parts[6]));
                int manyTimes = int.Parse(parts[6]);
                parts[7] = manyTimes.ToString();
            }else if(parts[2] == "Checklist Goal" && !(int.Parse(parts[6]) == int.Parse(parts[9]))){
                _pointsAchieved = _pointsAchieved + (int.Parse(parts[5]) * int.Parse(parts[6]));
                int manyTimes = int.Parse(parts[6]);
                parts[9] = manyTimes.ToString();
            }
            if(parts[2] == "Checklist Goal" && (int.Parse(parts[6]) == int.Parse(parts[7])) && !(int.Parse(parts[6]) == int.Parse(parts[9])))
            {
                _pointsAchieved = _pointsAchieved + int.Parse(parts[8]);
                int manyTimes = int.Parse(parts[6]);
                parts[9] = manyTimes.ToString();
            }                                
        }
        return _pointsAchieved;
    }

}