using System;

class Outdoor: Event
{
    private const string _eventType = "Outdoor gathering";
    public Outdoor(string title, string description, DateTime date, string place, string city, string state, string weather):
    base(_eventType,title,description,date,place,city, state, weather)
    {
    }
}