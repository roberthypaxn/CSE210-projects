using System;

//Job Class

public class Entry
{
    //member varialbles
    public string _currentTime = "";
    public string _journaledText = ""; 
    public string _promptMessage = "";
    
    //method
    public void written()
    {
        Console.WriteLine($"\nDate: {_currentTime}");
        Console.WriteLine($"engouragement: {_promptMessage}");
        Console.WriteLine($"Your entry: {_journaledText}");
        //The next line exists for beauty
        Console.WriteLine("------------------------------------------------------");

    }
}
