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
        _welcome = $"Welcome to the {_activity[0]} Activity";
        _description = _activity[1];
    }
   
    public void WelcomeMessage()
    {
        Console.WriteLine(_welcome);
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like your session? ");
        Console.WriteLine("\n");
        _seconds = int.Parse(Console.ReadLine());
    }

    public string GetChosenActivity()
    {
        return _activity[0];
    }

    public int GetChosenTime()
    {
        return _seconds;
    }
    public List<string> GetSpinner()
    {
        return spinners;
    }
    public void GetReady()
    {
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        Console.WriteLine("Get Ready");
        foreach(string spinner in spinners)
        {
            Console.Write(spinner);
            Thread.Sleep(600);
            Console.Write("\b \b");
        }
        Console.WriteLine("\n");
    }


}