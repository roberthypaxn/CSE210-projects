using System;

//Job Class

public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";

    public int _startYear = 0;

    public int _endYear = 0;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Job()
    {
    }
    public Job( string aCompany, string aJobTitle, int aStartYear, int aEndYear)
    {
        _jobTitle = aJobTitle;
        _company = aCompany;
        _startYear = aStartYear;
        _endYear = aEndYear;
    }

    //A method that displas the job title, name of company, beggining and ending year
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
}
