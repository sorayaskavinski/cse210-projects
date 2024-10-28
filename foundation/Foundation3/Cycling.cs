using System;
public class Cycling: Activity
{
    private double _speed;
    public Cycling(DateTime date, int duration, double speed): base(date, duration)
    {
        this._speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed/60)* base._duration;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double _distance = GetDistance();
        return base._duration/_distance;
    }
}