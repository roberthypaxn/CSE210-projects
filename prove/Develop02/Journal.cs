using System;

//Journal Class

public class Journal
{

    // List to store entries
    public List<Entry>_textEntries = new List<Entry>();

    //A method that displas the entries made
    public void Display()
    {
        foreach (Entry entry in _textEntries)
        {
            entry.written();
        }
    }

}