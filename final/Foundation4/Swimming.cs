using System;
class Swimming: Activity
{
    private int _laps;
    public Swimming(DateTime begin, DateTime end, int laps): base(begin, end)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return (_laps*50)/1000;
    }
    public override float GetSpeed()
    {
        return GetDistance()/(float)GetLengthOfTime().TotalHours;
    }
    public override float GetPace()
    {
        return (float)GetLengthOfTime().TotalMinutes/GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd")} {GetDate().ToString("MMM")} {GetDate().Year} Swimming ({-(GetLengthOfTime().TotalMinutes)} min)- Distance {GetDistance()} km, Speed {-((float)Math.Round(GetSpeed(), 2))} kph, Pace: {-((float)Math.Round(GetSpeed(), 2))} min per km";
    }
}