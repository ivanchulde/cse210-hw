public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }

    public ReflectingActivity(int duration) : base(duration)
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = duration;
    }

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready .....");
        ShowSpinner(5);
        DisplayPrompt();
        Console.WriteLine("Now Ponder on each of the following questions as they related to this experience\n");
        Console.Write("You may beggin:");
        ShowCountdown(5);
        Console.Clear();
        int elapsed = 0;
        while (elapsed < _duration)
        {

            DisplayQuestion();
            ShowSpinner(10);
            elapsed += 10;
            if (elapsed >= _duration) break;
            Console.WriteLine();
        }
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);

    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine("When you have something in mind, press enter continue");
        Console.ReadLine();
    }
    
    public void DisplayQuestion()
    {
        Console.Write($">{GetRandomQuestion()}");
        
    }
}