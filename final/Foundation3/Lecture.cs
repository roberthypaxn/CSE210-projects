using System;

class Lecture: Event
{
    private const string _eventType = "Lecture";
    public Lecture(string title, string description, string speaker, string capacity, DateTime date, string place, string city, string state):
    base(_eventType,title,description, speaker, capacity ,date,place,city, state)
    {
    }
}