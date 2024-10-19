using System.Diagnostics;

class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness App!");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();
                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        continue;
                }

                activity?.StartActivity();
            }
        }
    }
}