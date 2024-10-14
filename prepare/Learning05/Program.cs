using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Josh", "Fraction");
        Console.WriteLine(assignment1.GetSummary());
        Math assignment2 = new Math("Johnathan", "Fraction", "3", "10-12");
        Console.WriteLine(assignment2.GetHomeworkList());
        Writing assigment3 = new Writing("Suzan", "Poesy","The best Poesy Ever!");
        Console.WriteLine(assigment3.GetWritingInformation());
    }
}