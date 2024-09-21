using System;

public class Job
{
    public string _JobTitle;
    public string _JobCompany;
    public int _startYear;
    public int _endYear;

    punlic void Display()
    {
        Console.WriteLine($"{_JobTitle} ({_JobCompany}) {_startYear}-{_endYear}");
    }
}