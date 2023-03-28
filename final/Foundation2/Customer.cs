using System;

class Customer
{
    internal string _name;
    private string _street;
    private string _city;
    private string _provinceState;
    private string _country;
    public Customer(string name, string street, string city, string provinceState, string country)
    {
        _name = name;
        _street = street;
        _city = city;
        _provinceState = provinceState;
        _country = country;
    }
    public bool IsCitizen()
    {
        Address customerAddress = new Address(_street, _city, _provinceState, _country);
        return customerAddress.IsCitizen();
    }
    public string GetAddress()
    {
        Address customerAddress = new Address(_street, _city, _provinceState, _country);
        return customerAddress.GetAddress();
    }
}
