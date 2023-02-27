using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choix = Console.ReadLine();
        int choice = int.Parse(choix);

        
        switch (choice)
        {
            case 1:
                Breathing choice1 = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                choice1.WelcomeMessage();
                choice1.GetReady();
                choice1.BreatheInOut();
                choice1.WellDone();
                return;
            case 2:
                Activity choise2 = new Activity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and show you can use it in other aspects of your life.");
                choise2.WelcomeMessage();
                return;
            case 3:
                Activity choise3 = new Activity("Listing","This activity will help you reflect on the good tings in your life by having you list as many things as you can in a certain area.");
                choise3.WelcomeMessage();
                return;
            default:
                break;
        }
    }
}