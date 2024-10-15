using System;
public class Reflecting: Activity
{
    List<string> _prompts;
    List<string> _questions;
    public Reflecting(string name, string description, int duration, List<string> prompts, List<string> questions): base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {

    }
    public string GetRandomQuestion()
    {

    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }
}