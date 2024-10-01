using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        while(true)
        {
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());
            
            Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            s1.HideRandomWords(1);
            if (s1.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(s1.GetDisplayText());
                Console.WriteLine("\nAll words are now hidden. Exiting...");
                break;
            }
        }
        
    }
}