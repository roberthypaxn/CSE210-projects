using System;
class Cycling: Activity
{
    private float _speed;
    public Cycling(DateTime begin, DateTime end,int speed): base(begin, end)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
        return _speed * (float)GetLengthOfTime().TotalHours;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return (float)GetLengthOfTime().TotalMinutes/GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd")} {GetDate().ToString("MMM")} {GetDate().Year} Cycling ({-(GetLengthOfTime().TotalMinutes)} min)- Distance {-(GetDistance())} km, Speed {GetSpeed()} kph, Pace: {(float)Math.Round(GetPace(), 2)} min per km";
    }
}