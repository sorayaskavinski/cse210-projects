using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Reflecting : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflecting() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have.")
    {
    }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter to continue...");

        var spinnerTask = Task.Run(() => ShowSpinner());

        Console.ReadLine(); 
        _spinnerRunning = false;
        spinnerTask.Wait(); 

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            Console.WriteLine("Press Enter to continue...");

            spinnerTask = Task.Run(() => ShowSpinner());

            Console.ReadLine(); 
            _spinnerRunning = false;
            spinnerTask.Wait(); 
        }
    }

    private volatile bool _spinnerRunning = true;

    private void ShowSpinner()
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int index = 0;

        while (_spinnerRunning)
        {
            Console.Write(spinner[index++ % spinner.Length]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(100);
        }
        Console.WriteLine(); 
    }
}
