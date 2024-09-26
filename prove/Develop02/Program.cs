using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Choose one of the options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    LoadEntries(journal);
                    break;
                case "4":
                    SaveEntries(journal);
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        journal.AddEntry(new Entry(prompt, response));
        Console.WriteLine("Entry saved!");
    }

    private static void LoadEntries(Journal journal)
    {
        Console.Write("Enter the filename to load entries from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    private static void SaveEntries(Journal journal)
    {
        Console.Write("Enter the filename to save entries to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }
}
