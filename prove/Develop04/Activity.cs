using System;

public class Activity
{
    //activities
    private string _welcome;
    private int _seconds;
    private string _description;
    private List<string> spinners = new List<string>();
    private List<string> _activity = new List<string>();
    public Activity(string chosenActivity, string describeActivity)
    {
        _activity.Add(chosenActivity);
        _activity.Add(describeActivity);
        _welcome = $"\nWelcome to the {_activity[0]} Activity";
        _description = _activity[1];
    }
   
    public void WelcomeMessage()
    {
        Console.WriteLine(_welcome);
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like your session? ");
        _seconds = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
    }

    public string GetChosenActivity()
    {
        return _activity[0];
    }

    public int GetChosenTime()
    {
        return _seconds;
    }
    public void GetSpinner(int someTime)
    {
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(someTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string spin = spinners[i];
            Console.Write(spin);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= spinners.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine("\n");
    }
    public void GetReady()
    {
        
        Console.WriteLine("Get Ready...");
        GetSpinner(6);
        
    }
    public void WellDone()
    {
        Console.WriteLine("Well Done!");
        GetSpinner(5);
        Console.WriteLine($"You have completed another {_seconds} seconds of The {_activity[0]} Activity.");
        GetSpinner(5);
    }

}