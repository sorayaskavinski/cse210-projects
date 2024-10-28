using System;
public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int duration, int laps): base(date, duration)
    {
        this._laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50/1000.0;
    }
    public override double GetSpeed()
    {
        double _distance = GetDistance();
        return (_distance/base._duration)*60;
    }
    public override double GetPace()
    {
        double _distance = GetDistance();
        return base._duration/ _distance;
    }

}