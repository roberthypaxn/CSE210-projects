using System;

class Address
{
    private string _place;
    private string _city;
    private string _state;
    public Address(string place, string city, string state)
    {
        _place = place;
        _city = city;
        _state = state;
    }
    public Address()
    {
    }
    public string GetAddress()
    {
        return $"\nState: {_state}\nCity: {_city}\nVenue: {_place}";
    }

}