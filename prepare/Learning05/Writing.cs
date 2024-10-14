using System;
public class Writing: Assignment
{
    private string _title;
    public Writing(string studentName, string topic, string title): base(studentName,topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic} - '{_title}'";
    }
}