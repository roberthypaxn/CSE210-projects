using System;

abstract class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private DateTime _date = new DateTime();
    private Address _eventAdress;
    private string _eventType;
    private string _eventWeather;
    private string _rsvpEmail;
    private string _speaker;
    private string _capacity;
    private Event(string type,string title, string description, DateTime date, string place, string city, string state)
    {
        _eventType = type;
        _eventTitle = title;
        _eventDescription =description;
        _date = date;
        _eventAdress = new Address(place, city, state);
    }
    
    public Event(string email, string type,string title, string description, DateTime date, string place, string city, string state):
    this(type, title, description, date, place, city, state)
    {
        _rsvpEmail = email;
    }
    public Event(string type, string title, string description, DateTime date, string place, string city, string state, string weather):
    this(type, title, description, date, place, city, state)
    {
        _eventWeather = weather;   
    }
    public Event(string type, string title, string description, string speaker, string capacity, DateTime date, string place, string city, string state):
    this(type, title, description, date, place, city, state)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string StandarDetails()
    {
        return $"\nTitle: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_date.Day}/{_date.Month}/{_date.Year}\nTime: {_date.Hour}:{_date.Minute}\nAddress: {_eventAdress.GetAddress()}";
    }
    public string FullDetails()
    {
        if (_eventType == "Lecture")
        {
            return $"\nType of event: {_eventType}\nTitle: {_eventTitle}\nSpeaker's name: {_speaker}\nSpeaker's Capacity: {_capacity}\nDescription: {_eventDescription}\nDate: {_date.Day}/{_date.Month}/{_date.Year}\nTime: {_date.Hour}:{_date.Minute}\nAddress: {_eventAdress.GetAddress()}";
        }
        else if(_eventType == "Reception Event"){
            return $"\nType of event: {_eventType}\nRSVP email: {_rsvpEmail}\nTitle: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_date.Day}/{_date.Month}/{_date.Year}\nTime: {_date.Hour}:{_date.Minute}\nAddress: {_eventAdress.GetAddress()}";
        }
        else{
            return $"\nType of event: {_eventType}\nTitle: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_date.Day}/{_date.Month}/{_date.Year}\nTime: {_date.Hour}:{_date.Minute}\nAddress: {_eventAdress.GetAddress()}\n Weather: {_eventWeather}";
        }
    }
    public string ShortDercription()
    {
        return $"\nType of event: {_eventType}\nTitle: {_eventTitle}\nDate: {_date.Day}/{_date.Month}/{_date.Year}";
    }
}