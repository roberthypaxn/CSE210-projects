using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        DateTime beginner = new DateTime(2023, 04, 2, 8, 0, 0);
        DateTime finisher1 = new DateTime(2023, 04, 2, 8, 45, 0);
        DateTime finisher2 = new DateTime(2023, 04, 2, 9, 45, 0);
        DateTime finisher3 = new DateTime(2023, 04, 2, 11, 0, 0);

        List<Activity> activityList= new List<Activity>();
        Cycling bicycle = new Cycling(beginner, finisher1, 56);
        Swimming water = new Swimming(beginner, finisher1, 300);
        Running legs = new Running(beginner, finisher3, 25);
        activityList.Add(bicycle);
        activityList.Add(water);
        activityList.Add(legs);
        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }     
    }
}