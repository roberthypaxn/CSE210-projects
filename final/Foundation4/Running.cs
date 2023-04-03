using System;
class Running: Activity
{
    private float _distance;
    public Running(DateTime begin, DateTime end, float distance): base(begin, end)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return _distance/(float)GetLengthOfTime().TotalHours;
    }
    public override float GetPace()
    {
        return (float)GetLengthOfTime().TotalMinutes/_distance;
    }
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd")} {GetDate().ToString("MMM")} {GetDate().Year} Running ({-(GetLengthOfTime().TotalMinutes)} min)- Distance {GetDistance()} km, Speed {-((float)Math.Round(GetSpeed(), 2))} kph, Pace: {-((float)Math.Round(GetPace(), 2))} min per km";;
    }
}