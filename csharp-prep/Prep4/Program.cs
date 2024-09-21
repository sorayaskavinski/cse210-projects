using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers (either positive or negative), type 0 when finished.");

        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            {
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            float average = ((float)sum/numbers.Count);
            Console.WriteLine($"The average number is: {average}");

            // Find the smallest positive number before sorting
            int? smallestPositive = null;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                     if (smallestPositive == null || number < smallestPositive)
                    {
                        smallestPositive = number;
                    }               
                }
            }

            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number (closest to zero) is: {smallestPositive.Value}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            // Sort the numbers
            numbers.Sort();
            Console.WriteLine("Sorted numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); 
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
