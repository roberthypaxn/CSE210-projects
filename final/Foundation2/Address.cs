using System;

class Address
{
    private string _street;
    private string _city;
    private string _provinceState;
    private string _country;
    public Address(string street, string city, string provinceState, string country)
    {
        _street = street;
        _city = city;
        _provinceState = provinceState;
        _country = country;
    }
    public bool IsCitizen()
    {
        if(_country == "U.S.A")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetAddress()
    {
        return $"\n--Street Address: {_street}\n--City: {_city}\n--Province/State: {_provinceState}\n--country: {_country}\n";
    }
}