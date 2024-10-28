using System;
using System.Collections;
public abstract class Activity
{
    protected DateTime _date;
    protected  int _duration; //in minutes
    public Activity(DateTime date, int duration)
    {
        this._date = date;
        this._duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min) -"+
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}