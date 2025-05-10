using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number= randomGenerator.Next(1, 101);
        float guess_number = 0;
        int counter = 0;
        string again = "yes";

        
        while (guess_number != magic_number)
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            guess_number = float.Parse(guess);
            counter++;
            if (guess_number < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess_number > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Lower");
                Console.WriteLine($"Times: {counter}");
            }
        }
        


    
    }
}