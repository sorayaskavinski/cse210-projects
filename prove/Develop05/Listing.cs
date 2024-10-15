using System;
public class Listing: Activity
{
    private int _count;
    private List<string> _prompts;
    public Listing(string name, string description, int duration, int count, List<string> prompts): base(name, description, duration)
    {
        _count = count;
        _prompts = new List<string>
        {
            
        }
    }
    public void Run()
    {

    }
    public void GedRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        return $"{}";
    }
}