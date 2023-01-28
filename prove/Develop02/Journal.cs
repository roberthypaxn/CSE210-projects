using System;

//Journal Class

public class Journal
{

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public List<Entry>_textEntries = new List<Entry>();

    //A method that displas the Journal title, name of company, beggining and ending year
    public void Display()
    {
        foreach (Entry entry in _textEntries)
        {
            entry.written();
        }
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
}