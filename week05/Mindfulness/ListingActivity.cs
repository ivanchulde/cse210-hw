public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base ()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public ListingActivity(int duration) : base(duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = duration;
    }

    public ListingActivity(string name, string description, int duration, int count, List<string> _prompts) : base(name, description, duration)
    {
        _count = count;
        this._prompts = _prompts;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready to begin the Listing Activity.");
        ShowSpinner(5);
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You will begin in:");
        ShowCountdown(5);
        Console.WriteLine("\nStart listing items. Press Enter after each item:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            
            if (Console.KeyAvailable)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        ShowSpinner(3);

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($" --- {prompt} --- ");
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
    
}