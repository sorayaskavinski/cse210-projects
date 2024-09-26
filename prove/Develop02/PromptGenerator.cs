using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts { get; }
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Was there something you'd like to have said today?",
            "Is there something you'd like to change tomorrow?",
            "Was today a common day or had something different?"
        };
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        return _prompts[promptIndex];
    }
}
