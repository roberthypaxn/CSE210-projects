using System;

class Reception: Event
{
    private const string _eventType = "Reception Event";
    public Reception(string email, string title, string description, DateTime date, string place, string city, string state):
    base(email, _eventType,title,description,date,place,city, state)
    {
    }
}