//Today I helped my brother move, so I'm too tired to finish the program.... 
//it's not running exactly the way it's supposed...
//but I'll finish it tomorrow.. 
//I'll send it as it is for grading and do the extension and the missing part sometime this week..
// Sorry


using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        while (true)
        {
            Console.WriteLine("\n1. Display Player Info\n2. List Goal Names\n3. List Goal Details\n4. Create Goal\n5. Record Event\n6. Save Goals\n7. Load Goals\n8. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayPlayerInfo();
                    break;
                case "2":
                    manager.ListGoalNames();
                    break;
                case "3":
                    manager.ListGoalDetails();
                    break;
                case "4":
                    manager.CreateGoal();
                    break;
                case "5":
                    manager.RecordEvent();
                    break;
                case "6":
                    manager.SaveGoals();
                    break;
                case "7":
                    manager.LoadGoals();
                    break;
                case "8":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}