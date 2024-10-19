 class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description) : base("Breathing Activity", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void ExecuteActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                Pause(4);
                Console.WriteLine("Breathe out...");
                Pause(4);
            }
        }
    }