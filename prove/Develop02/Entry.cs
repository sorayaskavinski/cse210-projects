public class Entry
{
    public string _date { get; private set; }
    public string _promptText { get; }
    public string _entryText { get; }

        public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("MMMM dd yyyy HH:mm"); 
        _promptText = promptText;
        _entryText = entryText;
    }

       public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}
