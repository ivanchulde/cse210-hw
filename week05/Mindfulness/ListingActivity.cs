public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> _prompts) : base(name, description, duration)
    {
        _count = count;
        this._prompts = _prompts;
    }
    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
    
}