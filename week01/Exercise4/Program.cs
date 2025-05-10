using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> positive_numbers = new List<int>();
        int new_number = -1;
        float total = 0;
        
        Console.WriteLine("Entet a list of numbers, type 0 when finished.");

        while (new_number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            new_number = int.Parse(input);
            if (new_number != 0)
            {
                numbers.Add(new_number);
            }
            if (new_number > 0)
            {
                positive_numbers.Add(new_number);
            }
        }
        Console.WriteLine("The numbers are: ");
        foreach (int number in numbers)
        {
            total += number;
        }
        float average = ((float)total) / numbers.Count;
        int max_number = numbers.Max();
        int min_number = numbers.Min();
        numbers.Sort();
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max_number}");
        Console.WriteLine($"The smallest positive number is: {min_number}");
        Console.WriteLine("The sorted list of numbers is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
