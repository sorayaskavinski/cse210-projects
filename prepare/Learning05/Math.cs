using System;
public class Math : Assignment
{
    private string _section;
    private string _problems;
    public Math(string studentName, string topic, string section, string problems): base (studentName, topic)
    {
        _section = section;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\n Section: {_section}\n Problems: {_problems}";
    }
}