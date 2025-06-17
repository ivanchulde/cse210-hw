public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    { 
        
    }

    public Activity(int duration)
    {
        _duration = duration;
    }
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    

    public void DispplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);

    }

    public void DisplayEndingMessage() {
        
        Console.WriteLine($"You completed the activity in {_duration} seconds.");
    }

    public void ShowSpinner(int seconds) {
        List<string> animationStrings = new List<string> ();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < endTime) 
        {
            string s = animationStrings [i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count) {
                i = 0;
            }
        }
        
    }

    public void ShowCountdown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}