public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest! Let's set some goals!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal short name: ");
        string shortName = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter goal type (simple, eternal, checklist): ");
        string goalType = Console.ReadLine().ToLower();

        Goal newGoal = null;

        switch (goalType)
        {
            case "simple":
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case "checklist":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type!");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine($"Goal '{shortName}' created successfully!");
    }

    public void RecordEvent()
    {
        Console.Write("Enter the short name of the goal to record an event: ");
        string shortName = Console.ReadLine();
        foreach (var goal in _goals)
        {
            if (goal.GetStringRepresentation() == shortName)
            {
                int points = goal.RecordEvent();
                if (points > 0)
                {
                    _score += points;
                    Console.WriteLine($"Recorded event for '{shortName}'. Gained {points} points.");
                }
                else
                {
                    Console.WriteLine($"Goal '{shortName}' is already complete.");
                }
                return;
            }
        }
        Console.WriteLine($"No goal found with short name '{shortName}'.");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine($"{goalType},{goal.GetStringRepresentation()},{goal.GetDetailsString()}");
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }
    public void UploadGoals()
    {
        Console.Write("Enter the path of the goals file to upload: ");
        string filePath = Console.ReadLine();
    
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Please check the path and try again.");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();            
            }
        }
        Console.WriteLine("Goals uploaded successfully!");
    }
}
