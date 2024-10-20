public class Listing : Activity
    {
        private readonly List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public Listing() : base("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
        {
        }

        protected override void ExecuteActivity()
        {
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Pause(5); // Time to think about the prompt

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            Console.WriteLine("Start listing (type 'done' to finish):");
            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "done") break;
                items.Add(item);
            }

            Console.WriteLine($"You listed {items.Count} items.");
        }
    }
