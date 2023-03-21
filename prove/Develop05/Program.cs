using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        /*************************************************/
        int goalNumber = 1;

        string[] liners = System.IO.File.ReadAllLines("goals.txt");
        if(liners.Count() == 0)
        {
            goalNumber = 1;
        } else{
            goalNumber = liners.Count() + 1;
        }
        /*************************************************/
        List<string> GetSavedGoals()
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
                goalNumber = numberOfGoals + 1;
            }
            return savedGoals;
        }
        
        /*************************************************/
        int pointsAchieved = 0;
        void LoadGoals()
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
        /*************************************************/
        string goal;
        List<string> currentGoals = new List<string>();
        void ListGoals()
        {
            foreach (string oneGoal in currentGoals)
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
        /*************************************************/

        int typeOfGoal = 0;
        Simple simpleGoal = new Simple("Simple Goal");
        Eternal eternalGoal = new Eternal("Eternal Goal");
        Checklist checklistGoal = new Checklist("Checklist Goal");
        

        while (choice != 6)
        {
            int accomplished = Achievement();
            pointsAchieved = accomplished;
            goalNumber = currentGoals.Count() + liners.Count() +1;
            Console.WriteLine();
            Console.WriteLine($"You have {pointsAchieved} points"); //{simpleGoal.GetPoints()}
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goals");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choix = Console.ReadLine();
            choice = int.Parse(choix);

            switch (choice)
            {
                case 1:
                    while (!(typeOfGoal == 1 || typeOfGoal == 2 || typeOfGoal == 3))
                    {
                        Console.WriteLine("The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        string _type = Console.ReadLine();
                        typeOfGoal = int.Parse(_type);
                    }
                    switch(typeOfGoal)
                    {
                        case 1:
                            goal = simpleGoal.CreateGoal(goalNumber);
                            currentGoals.Add(goal);
                            foreach(string line in currentGoals)
                            {
                                Console.WriteLine(line);
                            }
                            break;
                        case 2:
                            goal = eternalGoal.CreateGoal(goalNumber);
                            currentGoals.Add(goal);
                            foreach(string line in currentGoals)
                            {
                                Console.WriteLine(line);
                            }
                            break;
                        case 3:
                            goal = checklistGoal.CreateGoal(goalNumber);
                            currentGoals.Add(goal);
                            foreach(string line in currentGoals)
                            {
                                Console.WriteLine(line);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    IsComplete();
                    break;
                default:
                    break;
            }
            typeOfGoal = 0;
            pointsAchieved = pointsAchieved - accomplished;
        }
        List<string> GetAllGoals()
        {
            
            List<string> allGoals = new List<string>();
            foreach (string line in GetSavedGoals())
            {
                allGoals.Add(line);
                
            }
            
            foreach (string line in currentGoals)
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
        void SaveGoals()
        {
            // read the file, see what's in it. If any lines in all list is in the file, don't rewrite it.
            List<string> allGoals = GetAllGoals();
            //List<string> saved = GetSavedGoals();
            
            using (StreamWriter goalsFile = new StreamWriter("goals.txt",false))
            {
                foreach (string goal in allGoals)
                {
                    goalsFile.WriteLine(goal);
                }
            }
        }
       void IsComplete()
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
            Console.WriteLine("Which goal did you accomplish? ");
            string completeGoal = Console.ReadLine();
            int completedGoal = int.Parse(completeGoal);
            string oneDown = all[completedGoal-1];
            string[] partsOfAchievedGoal = oneDown.Split("~");
            List<string> savedOnes =GetSavedGoals();
            if(currentGoals.Contains(oneDown) && !(savedOnes.Contains(oneDown)))
            {
                int indexOfGoal = currentGoals.IndexOf(oneDown);
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
                if(currentGoals.Count() == 1)
                {
                    currentGoals[0] = oneDown;
                }else{
                    currentGoals[indexOfGoal] = oneDown;
                }
                
            }else if(currentGoals.Contains(oneDown) && savedOnes.Contains(oneDown)){
                int indexOfGoal = currentGoals.IndexOf(oneDown);
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
                if(currentGoals.Count() == 1)
                {
                    currentGoals[0] = oneDown;
                }else if(!(savedOnes.Count() == 0) && !(currentGoals.Count() == 0)){
                    currentGoals[indexOfGoal] = oneDown;
                }else{
                    currentGoals[indexOfGoal] = oneDown;
                }
                if(savedOnes.Count() == 1){
                    savedOnes[0] = oneDown;
                }else{
                    savedOnes[indexOfGoal] = oneDown;
                }
                using (StreamWriter goalsFile = new StreamWriter("goals.txt",false))
                {
                    foreach (string goal in savedOnes)
                    {
                        goalsFile.WriteLine(goal);
                    }
                }
            }else if(savedOnes.Contains(oneDown) && !(currentGoals.Contains(oneDown)))//!!! if savedOnes goal number + goal name + description is equal to those in oneDown
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
                        Console.WriteLine(goal);
                    }
                }
            }
            
        }
        int Achievement()
        {
            List<string> goals = GetAllGoals();
            foreach(string goal in goals)
            {
                string[] parts =goal.Split("~");
                if(parts[2] == "Simple Goal" && parts[1] == "X" && !(parts[5] == "done"))
                {
                    pointsAchieved = pointsAchieved + int.Parse(parts[5]);
                    parts[5] = "done";
                }else if(parts[2] == "Eternal Goal" && !(parts[6] == "0") && parts[7]=="0"){
                    pointsAchieved = pointsAchieved + (int.Parse(parts[5]) * int.Parse(parts[6]));
                    int manyTimes = int.Parse(parts[6]);
                    parts[7] = manyTimes.ToString();
                }else if(parts[2] == "Eternal Goal" && !(parts[6] == "0") && !(int.Parse(parts[7])== int.Parse(parts[6]))){
                    pointsAchieved = pointsAchieved + (int.Parse(parts[5]) * int.Parse(parts[6]));
                    int manyTimes = int.Parse(parts[6]);
                    parts[7] = manyTimes.ToString();
                }else if(parts[2] == "Checklist Goal" && !(int.Parse(parts[6]) == int.Parse(parts[9]))){
                    pointsAchieved = pointsAchieved + (int.Parse(parts[5]) * int.Parse(parts[6]));
                    int manyTimes = int.Parse(parts[6]);
                    parts[9] = manyTimes.ToString();
                }
                if(parts[2] == "Checklist Goal" && (int.Parse(parts[6]) == int.Parse(parts[7])) && !(int.Parse(parts[6]) == int.Parse(parts[9])))
                {
                    pointsAchieved = pointsAchieved + int.Parse(parts[8]);
                    int manyTimes = int.Parse(parts[6]);
                    parts[9] = manyTimes.ToString();
                }                                
            }
            return pointsAchieved;
        }
    }
}
/*If a goal is in current goal and is in saved goals
-put a cross on it if it's a simple goal and replace the one with the cross in current goals and saved goals.
-if it's an eternal goal add up achievements and replace it in current goals everytime it's achieved.
-if it's a checklist goal add up achievements and replace it in current goals everytime it's achieved,if achievements are equal to levels put a cross on it and replace it in current goals*/