using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUsername();
        int userNumber = PromptUserNumber();
        int squareNumber = squaredNumber(userNumber);

        DisplayResult (name, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
        
    }
    static string PromptUsername()
    {
        Console.Write("Please write your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine ());
        
        return number;
    }

    static int squaredNumber (int number)
    {
        int squareUserNumber = number * number;
        return squareUserNumber;

    }
    static void DisplayResult(string userName, int squareUserNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareUserNumber}.");
    }
}