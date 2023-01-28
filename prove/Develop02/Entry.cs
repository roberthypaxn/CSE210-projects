using System;

//Job Class

public class Entry
{
    //member varialbles
    public string _currentTime = "";
    public string _journaledText = ""; 
    public string _promptMessage = "";
    // new keyword followed by the class name and parentheses.
    
    //method
    public void written()
    {
        Console.WriteLine($"\nDate: {_currentTime}");
        Console.WriteLine($"engouragement: {_promptMessage}");
        Console.WriteLine($"Your entry: {_journaledText}");
        Console.WriteLine("------------------------------------------------------");

    }
}
