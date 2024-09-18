using System;
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage?");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter;
        if (percentage >= 90)
        {
            if (percentage <=93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (percentage >= 80 && percentage <=89)
        {
            if (percentage >=87)
            {
                letter = "B+";
            }
            else if (percentage <=83)
            {
                letter ="B-";
            }
            else{
                letter = "B";
            }
        }
        else if (percentage >=70 && percentage <= 79)
        {
            if (percentage >=77)
            {
                letter = "C+";
            }
            else if (percentage <=73)
            {
                letter ="C-";
            }
            else{
                letter = "C";
            }
        }
        else if (percentage >=60 && percentage <=69)
        {
            if (percentage >=67)
            {
                letter = "D+";
            }
            else if (percentage <=63)
            {
                letter ="D-";
            }
            else{
                letter = "D";
            }
        }
        else
        {
            if (percentage >=57)
            {
                letter = "F+";
            }
            else{
                letter = "F";
            }
        }
        Console.WriteLine($"Your letter is {letter}");

        if (percentage >=70)
        {
            Console.WriteLine(" You passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("Sorry, but you failed this time.");
        }
    }
}