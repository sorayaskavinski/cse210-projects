using System;
public class Running: Activity
{
    private double _distance;
    public Running(DateTime date, int duration, double distance): base(date, duration)
    {
        this._distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance/base._duration)* 60;
    }
    public override double GetPace()
    {
        return base._duration/ _distance;
    }
}