using System;

class Program
{
    static void Main(string[] args)
    {
       bool playAgain;

        do
        {
            playAgain = PlayGame();
        } while (playAgain);
    }

    static bool PlayGame()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int numberOfGuesses = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

        while (guess != magicNumber)
        {
            Console.Write("What's your guess? ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out guess))
            {
                numberOfGuesses++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {magicNumber}!");
                    Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.Write("Do you want to play again? (yes/no): ");
        string playAgainInput = Console.ReadLine().ToLower();

        return playAgainInput == "yes";
    }
}