using System;
class Activity
{
    private DateTime _beginningTime;
    private DateTime _endTime;
    private TimeSpan _lengthOfTime;
    public Activity(DateTime begin, DateTime end)
    {
        _beginningTime = begin;
        _endTime = end;
        _lengthOfTime = begin - end;
    }
    public TimeSpan GetLengthOfTime()
    {
        return _lengthOfTime;
    }
    public DateTime GetDate()//may not work if called from derived classes (check)
    {
        return _beginningTime;
    }
    
    public virtual float GetDistance()
    {
        return 0;
    }
    public virtual float GetSpeed()
    {
        return 0;
    }
    public virtual float GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}