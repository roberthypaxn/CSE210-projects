using System;

class Breathing : Activity
{

    public Breathing(string chosenActivity, string describeActivity) : base(chosenActivity, describeActivity)
    {
    }
    public void BreatheInOut()
    {
        int _sessionTime = GetChosenTime();
        
        int timeSpent = 0;
        while (timeSpent < _sessionTime)
        {
            Console.Write($"Breathe in... ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.Write("\b\b \b");
            }
            Console.WriteLine();

            Console.Write($"Breathe out... ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.Write("\b\b \b");
            }
            Console.WriteLine("\n");
            timeSpent += 10;
        }
    }
    public void WellDone()
    {
        int _timing = GetChosenTime();
        string _chosenActivity = GetChosenActivity();
        var spins = GetSpinner();
        spins.Add("|");
        spins.Add("/");
        spins.Add("-");
        spins.Add("\\");
        spins.Add("|");
        spins.Add("/");
        spins.Add("-");
        spins.Add("\\");
        Console.WriteLine("Well Done!");
        foreach(string spinner in spins)
        {
            Console.Write(spinner);
            Thread.Sleep(600);
            Console.Write("\b \b");
        }
        Console.WriteLine("\n");
        Console.WriteLine($"You have completed {_timing} seconds of the {_chosenActivity} Activity");
        foreach(string spinner in spins)
        {
            Console.Write(spinner);
            Thread.Sleep(600);
            Console.Write("\b \b");
        }
    }
        
        
    
}