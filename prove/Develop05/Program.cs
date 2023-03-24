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

        string goal;
        List<string> currentGoals = new List<string>();

        int pointsAchieved = 0;
        int typeOfGoal = 0;

        GoalManager goalManager = new GoalManager(goalNumber, currentGoals, pointsAchieved);

        Simple simpleGoal = new Simple("Simple Goal");
        Eternal eternalGoal = new Eternal("Eternal Goal");
        Checklist checklistGoal = new Checklist("Checklist Goal");
        
        int visits = 0;
        while (choice != 6)
        {
            int accomplished = goalManager.Achievement();
            pointsAchieved = accomplished;
            goalNumber = currentGoals.Count() + liners.Count() +1;

            Console.WriteLine();
            if(visits == 0 && pointsAchieved == 0)
            {
                Console.WriteLine("Welcome!\n");
                Console.WriteLine($"You have {pointsAchieved} points");
            } else if(visits==0 && !(pointsAchieved ==0)){
                Console.WriteLine($"Welcome back!! You now have {pointsAchieved} points");
            } else if(!(visits == 0)){
                Console.WriteLine($"You have {pointsAchieved} points");
            }
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
                            break;
                        case 2:
                            goal = eternalGoal.CreateGoal(goalNumber);
                            currentGoals.Add(goal);
                            break;
                        case 3:
                            goal = checklistGoal.CreateGoal(goalNumber);
                            currentGoals.Add(goal);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    goalManager.ListGoals();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.IsComplete();
                    break;
                default:
                    break;
            }
            typeOfGoal = 0;
            visits = visits +1;
        }
    }
}