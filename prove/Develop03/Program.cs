//extended - I put 3 scriptures to memorize - where the program will loop at each scripture and
//stop after each one has been memorized

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16, 18);
        Scripture s1 = new Scripture(r1, "16 For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."+
            "17 For God did not send his Son into the world to condemn the world, but to save the world through him." +
            "18 Whoever believes in him is not condemned, but whoever does not believe stands condemned already because they have not believed in the name of God’s one and only Son.");

        Reference r2 = new Reference ("Proverbs",3,5,6);
        Scripture s2 = new Scripture (r2,"5 Trust in the Lord with all your heartand lean not on your own understanding" +
            "6 in all your ways submit to him,and he will make your paths straight.");
        
        Reference r3 = new Reference("Philippians", 4, 13);
        Scripture s3 = new Scripture(r3, "I can do all things through Christ which strengtheneth me.");
        
        Scripture[] scriptures = {s1,s2,s3};

        foreach(var scripture in scriptures)
        {
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
        Console.WriteLine("All scriptures have been memorized!");        
    }
}