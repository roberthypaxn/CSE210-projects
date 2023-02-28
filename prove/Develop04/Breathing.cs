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
    
}