public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Take a moment to think about it.");

    }
    
    public void DisplayQuestion()
    {
        Console.WriteLine("Consider the following question:");
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine("Take a moment to think about it.");
    }
}