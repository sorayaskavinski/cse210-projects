using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; }
    protected string Description { get; }
    protected int Duration { get; private set; }

    protected Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting Activity: {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start...");
        Pause(3); 
        ExecuteActivity();
        EndActivity();
    }

    protected abstract void ExecuteActivity();

    private void EndActivity()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Pause(2);
        Console.WriteLine($"You spent {Duration} seconds on {Name}.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

